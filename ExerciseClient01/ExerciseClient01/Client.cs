using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseClient01
{
    public partial class Client : MetroFramework.Forms.MetroForm
    {
        // 서버가 접속할 소켓에서 listen accept할 변수
        private Socket listener = null;
        private Socket handler = null;

        // 데이터 버퍼
        private byte[] bytes = new byte[1024];

        public Client()
        {
            InitializeComponent();

            FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (handler != null)
            {
                handler.Close();
                handler.Dispose();
            }
            if (listener != null)
            {
                listener.Close();
                listener.Dispose();
            }

            Application.Exit();
        }

        /// <summary>
        /// Local IP를 반환해주는 메소드
        /// </summary>
        /// <returns></returns>
        public static string LocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    return localIP;
                }
            }
            return "127.0.0.1";
        }

        /// <summary>
        /// 서버 접속 요청 대기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connectButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                IPAddress localIPAddress = IPAddress.Parse(LocalIPAddress());
                IPEndPoint localEndPoint = new IPEndPoint(localIPAddress, 12000);

                // TCP/IP 소켓 생성
                listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                listener.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

                try
                {
                    new Thread(() =>
                    {
                        listener.Bind(localEndPoint);
                        listener.Listen(10);

                        // 서버 접속 요청 대기 시작
                        while (true)
                        {
                            Invoke(new MethodInvoker(delegate()
                            {
                                messageListBox.Items.Add("Waiting for connections ....");
                            }));

                            // 연결이 들어오는 동안 프로그램 일시정지
                            handler = listener.Accept();
                            Invoke(new MethodInvoker(delegate()
                            {
                                messageListBox.Items.Add("클라이언트 연결 ... OK");
                            }));
                        }
                    }).Start();
                }
                catch (SocketException se)
                {
                    MessageBox.Show("SocketException 에러 : " + se.ToString());
                    switch (se.SocketErrorCode)
                    {
                        case SocketError.ConnectionAborted:
                        case SocketError.ConnectionReset:
                            handler.Shutdown(SocketShutdown.Both);
                            handler.Close();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception 에러 : " + ex.ToString());
                }
            });

            thread.Start();
        }

        /// <summary>
        /// 서버와 연결 완료 후 메시지 보내기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendButton_Click(object sender, EventArgs e)
        {
            string data = null;

            try
            {
                // 서버에게 보낼 메시지를 byte 배열을 이용해서 Encoding 해준다.
                byte[] message = Encoding.UTF8.GetBytes(sendMsgTextBox.Text + "<eof>");
                int bytesSent = handler.Send(message);
                int bytesRec = handler.Receive(bytes);

                if (bytesSent <= 0)
                {
                    throw new SocketException();
                }

                // 클라이언트에서 보낸 메시지를 Server에서 받고, Server가 다시 바로 Client에게 받은 메시지를 그대로 Send한다.
                data += Encoding.UTF8.GetString(bytes, 0, bytesRec);

                Invoke(new MethodInvoker(delegate()
                {
                    messageListBox.Items.Add(data);
                }));
            }
            catch (SocketException se)
            {
                MessageBox.Show("SocketException 에러 : " + se.ToString());
                handler.Close();
                handler.Dispose();
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show("현재 클라이언트와 서버가 연결되지 않았습니다.");
            }
        }
    }
}
