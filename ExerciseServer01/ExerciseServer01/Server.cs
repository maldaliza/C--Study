using System;
using System.Collections;
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

namespace ExerciseServer01
{
    public partial class Server : MetroFramework.Forms.MetroForm
    {
        ArrayList socketList = new ArrayList();

        public static string data = null;

        // 클라이언트로부터 오는 메시지를 받을 버퍼
        private byte[] bytes = new byte[1024];

        public List<string> clientIP = new List<string>();

        /// <summary>
        /// 생성자
        /// </summary>
        public Server()
        {
            InitializeComponent();

            // 폼이 닫히기 전에 발생하는 이벤트
            FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }

        /// <summary>
        /// 폼이 닫히기 전에 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (socketList != null)
            {
                socketList = null;
            }
            Application.Exit();
        }

        private string TruncateLeft(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        /// <summary>
        /// "클라이언트 접속 확인" 버튼 클릭 이벤트
        /// 서버가 가지고 있는 클라이언트 IP 리스트를 계속 확인 → 해당 클라이언트가 접속해오는지 체크
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            SocketServer();
        }

        /// <summary>
        /// 클라이언트로부터 접속 연결 및 데이터를 받는 함수
        /// </summary>
        public void SocketServer()
        {
            ClientIPStore();    // 서버가 관리할 클라이언트 IP를 List에 저장

            // 클라이언트 IP를 알아서 해당 클라이언트에게 접속 요청
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        foreach (string client in clientIP)
                        {
                            // TCP/IP 소켓 생성
                            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                            // 클라이언트의 IP와 포트번호를 이용해 접속 시도
                            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(client), 12000);

                            // 각 클라이언트를 Search할 때, Timeout을 걸어준다.
                            IAsyncResult result = socket.BeginConnect(IPAddress.Parse(client), 12000, null, null);
                            bool success = result.AsyncWaitHandle.WaitOne(500, true);

                            // 접속 실패
                            if (!success)
                            {
                                FailConnect(socket, client);
                            }
                            // 접속 성공
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SuccessConnect(socket, client);
                                });
                            }
                        }
                    }
                    catch (SocketException se)
                    {
                        MessageBox.Show("해당 클라이언트가 없습니다.");
                    }

                    Invoke((MethodInvoker)delegate
                    {
                        disconnectTextBox.AppendText(Environment.NewLine);
                        connectTextBox.AppendText(Environment.NewLine);
                    });
                    Thread.Sleep(3000);
                }
            });

            thread.Start();
        }

        private void FailConnect(Socket socket, string client)
        {
            // NOTE, MUST CLOSE THE SOCKET
            socket.Close();

            Invoke((MethodInvoker)delegate
            {
                disconnectTextBox.AppendText("IP : " + client + " 연결 실패" + Environment.NewLine);
            });
        }

        private void SuccessConnect(Socket socket, string client)
        {
            connectTextBox.AppendText("IP : " + client + " 연결 성공" + Environment.NewLine);
            socketList.Clear();

            // 현재 연결되어있는 클라이언트들만 따로 ArrayList에 저장
            socketList.Add(socket);

            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        data = null;

                        // 클라이언트에서 들어오는 연결을 처리
                        while (true)
                        {
                            bytes = new byte[1024];
                            int bytesRec = socket.Receive(bytes);
                            data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
                            Thread.Sleep(500);
                            if (data.IndexOf("<eof>") > -1)
                            {
                                break;
                            }
                        }

                        // Truncate the <eof>
                        data = TruncateLeft(data, data.Length - 5);

                        // 클라이언트에서 받은 메시지를 listbox로 보여준다.
                        Invoke((MethodInvoker)delegate
                        {
                            messageTextBox.AppendText(string.Format(client + " received : {0}", data) + Environment.NewLine);
                        });

                        // 클라이언트에서 받은 메시지를 다시 클라이언트에 에코해준다.
                        data = "[Server Echo 메시지] " + data;
                        byte[] message = Encoding.UTF8.GetBytes(data);

                        foreach (Socket socketIterator in socketList)
                        {
                            socketIterator.Send(message);
                        }
                    }
                    catch
                    {
                        socket.Close();
                        socket.Dispose();
                        break;
                    }
                }
            });
            thread.Start();
        }

        /// <summary>
        /// 서버가 관리하는 클라이언트 IP를 List를 이용하여 저장하고 있다.
        /// </summary>
        private void ClientIPStore()
        {
            clientIP.Add("192.168.2.47");
            clientIP.Add("192.168.2.1");
            clientIP.Add("192.168.2.4");
            clientIP.Add("192.168.2.7");
        }
    }
}
