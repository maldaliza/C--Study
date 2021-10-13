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

namespace ThreadExercise03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. 쓰레드 객체 생성
            Thread thread1 = new Thread(() =>
            {
                CrossThreadPrevention(textBox1, 5, "AAA");
            });

            Thread thread2 = new Thread(() => 
            {
                CrossThreadPrevention(textBox1, 3, "BBB");
            });

            // 2. 쓰레드 실행
            thread1.Start();
            thread2.Start();
        }

        /// <summary>
        /// 크로스 쓰레드 방지 메소드
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <param name="text"></param>
        private void CrossThreadPrevention(Control item, int index, string text)
        {
            // 1. 해당 컨트롤이 Invoke가 필요한 상황인지 판별
            if (item.InvokeRequired)
            {
                Console.WriteLine(item.InvokeRequired + " - " + text);

                // 2. Invoke가 필요한 상황이라면 Invoke 실행
                item.Invoke(new MethodInvoker(delegate() 
                {
                    // 3. 해당 컨트롤의 코드 실행
                    for (int i=0; i<index; i++)
                    {
                        textBox1.Text += text + Environment.NewLine;
                    }
                }));
            }

            // Invoke가 필요없는 상황이라면, 기존 쓰레드에서 코드 실행
            else
            {
                AccessToControl(textBox1, index, text);
            }
        }

        private void AccessToControl(TextBox textBox1, int index, string text)
        {
            for (int i=0; i<index; i++)
            {
                textBox1.Text += text + Environment.NewLine;
            }
        }
    }
}
