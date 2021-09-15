using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button button0 = (Button)sender;
            textBox1.Text += button0.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button2 = (Button)sender;
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button3 = (Button)sender;
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button4 = (Button)sender;
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button5 = (Button)sender;
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button6 = (Button)sender;
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button7 = (Button)sender;
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button8 = (Button)sender;
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button9 = (Button)sender;
            textBox1.Text += button8.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Button clearButton = (Button)sender;
            textBox1.Text = "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            Button plusButton = (Button)sender;
            textBox1.Text += plusButton.Text;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            Button minusButton = (Button)sender;
            textBox1.Text += minusButton.Text;
        }
        private void multipleButton_Click(object sender, EventArgs e)
        {
            Button multipleButton = (Button)sender;
            textBox1.Text += multipleButton.Text;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            Button divideButton = (Button)sender;
            textBox1.Text += divideButton.Text;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            string[] plusSplit = textBox1.Text.Split('+');
            double result = 0;
            
            for (int i=0; i<plusSplit.Length; i++)
            {
                string[] minusSplit = plusSplit[i].Split('-');
                double minusSplitResult = 0;
                
                for (int j=0; j<minusSplit.Length; j++)
                {
                    string[] multiSplit = minusSplit[j].Split('*');
                    double multiSplitResult = 0;
                    
                    for (int k=0; k<multiSplit.Length; k++)
                    {
                        string[] divSplit = multiSplit[k].Split('/');
                        double divSplitResult = 0;

                        for (int l=0; l<divSplit.Length; l++)
                        {
                            if (l==0)
                            {
                                divSplitResult += Convert.ToDouble(divSplit[l]);
                            } else
                            {
                                divSplitResult /= Convert.ToDouble(divSplit[l]);
                            }
                        }

                        multiSplit[k] = Convert.ToString(divSplitResult);
                        if (k==0)
                        {
                            multiSplitResult += Convert.ToDouble(multiSplit[k]);
                        } else
                        {
                            multiSplitResult *= Convert.ToDouble(multiSplit[k]);
                        }
                    }

                    minusSplit[j] = Convert.ToString(multiSplitResult);
                    if (j==0)
                    {
                        minusSplitResult += Convert.ToDouble(minusSplit[j]);
                    } else
                    {
                        minusSplitResult -= Convert.ToDouble(minusSplit[j]);
                    }
                }

                plusSplit[i] = Convert.ToString(minusSplitResult);

                result += Convert.ToDouble(plusSplit[i]);
            }
            textBox1.Text += Environment.NewLine + Convert.ToString(result);
        }
    }
}
