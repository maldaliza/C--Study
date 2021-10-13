using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadExercise02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Thread aThread = new Thread(() =>
            {
                CrossThreadPrevention(textBox1, 10, "jaekook");
            });
            Thread bthread = new Thread(() =>
            {
                CrossThreadPrevention(textBox1, 5, "BBB");
            });

            aThread.Start();
            bthread.Start();
        }

        /// <summary>
        /// 메인 쓰레드와 UI 쓰레드 충돌 방지
        /// 크로스 쓰레드 방지 메소드
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <param name="text"></param>
        public static void CrossThreadPrevention(Control item, int index, string text)
        {
            // 해당 item이 Invoke이 필요한 경우
            if (item.InvokeRequired)
            {
                // True를 반환하면 Invoke 메소드 호출을 필요로 하는 상태
                // False를 반환하면 컨트롤에 직접 접근해도 문제가 없는 상태
                Console.WriteLine(item.InvokeRequired);

                /*
                item.BeginInvoke((MethodInvoker)delegate
                {
                    for (int i = 0; i < index; i++)
                    {
                        item.Text += text + Environment.NewLine;
                    }
                });
                */
                item.Invoke(new MethodInvoker(delegate()
                {
                    for (int i=0; i<index; i++)
                    {
                        item.Text += text + Environment.NewLine;
                    }
                }));
            }
        }
    }
}
