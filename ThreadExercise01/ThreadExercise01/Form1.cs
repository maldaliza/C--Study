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

namespace ThreadExercise01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += FormLoad_Event;
        }

        /// <summary>
        /// Form 로드 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoad_Event(object sender, EventArgs e)
        {
            // 스레드 선언
            Thread aThread = new Thread(new ThreadStart(A));
            Thread bThread = new Thread(delegate ()
            {
                CrossThreadPrevention(textBox1, 5, "B");
            });
            Thread cThread = new Thread(() => 
            {
                CrossThreadPrevention(textBox1, 10, "C");
            });

            // 스레드 시작
            aThread.Start();
            bThread.Start();
            cThread.Start();
        }

        private void A()
        {
            CrossThreadPrevention(textBox1, 10, "A");
        }

        /// <summary>
        /// UI 스레드와 기본 스레드 간의 충돌 방지 메소드
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <param name="text"></param>
        public static void CrossThreadPrevention(Control item, int index, string text)
        {
            if (item.InvokeRequired)
            {
                item.BeginInvoke((MethodInvoker)delegate
                {
                    for (int i=0; i<index; i++)
                    {
                        item.Text += text;
                    }
                });
            }
        }
    }
}
