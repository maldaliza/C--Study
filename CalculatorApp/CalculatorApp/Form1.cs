using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn0 = (Button) sender;
            textBox1.Text += btn0.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button) sender;
            textBox1.Text += btn1.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn2 = (Button)sender;
            textBox1.Text += btn2.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn3 = (Button)sender;
            textBox1.Text += btn3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn4 = (Button)sender;
            textBox1.Text += btn4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn5 = (Button)sender;
            textBox1.Text += btn5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn6 = (Button)sender;
            textBox1.Text += btn6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn7 = (Button)sender;
            textBox1.Text += btn7.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn8 = (Button)sender;
            textBox1.Text += btn8.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn9 = (Button)sender;
            textBox1.Text += btn9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btnDot = (Button)sender;
            textBox1.Text += btnDot.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] plusSplit = textBox1.Text.Split('+');  // 텍스트박스의 텍스트를 '+'로 Split 합니다.

            double result = 0;

            for (int i=0; i<plusSplit.Length; i++)
            {
                string[] minusSplit = plusSplit[i].Split('-');
                double minusSplitResult = 0;

                for (int j=0; j<minusSplit.Length; j++)
                {
                    if (j==0)
                    {
                        minusSplitResult += Convert.ToDouble(minusSplit[j]);
                    }
                    else
                    {
                        minusSplitResult -= Convert.ToDouble(minusSplit[j]);
                    }
                }
                plusSplit[i] = Convert.ToString(minusSplitResult);

                Console.WriteLine(plusSplit[i]);
                result += Convert.ToDouble(plusSplit[i]);
            }

            textBox1.Text += Environment.NewLine + Convert.ToString(result);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button btnClear = (Button)sender;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btnPlus = (Button)sender;
            textBox1.Text += btnPlus.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btnMinus = (Button)sender;
            textBox1.Text += btnMinus.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button btnMultiple = (Button)sender;
            textBox1.Text += btnMultiple.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button btnDivide = (Button)sender;
            textBox1.Text += btnDivide.Text;
        }
    }
}
