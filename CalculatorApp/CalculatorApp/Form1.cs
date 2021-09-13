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
            Button btnEqual = (Button)sender;
            textBox1.Text += btnEqual.Text;
        }
    }
}
