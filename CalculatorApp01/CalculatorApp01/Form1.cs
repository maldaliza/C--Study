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

        private void leftBracket_Click(object sender, EventArgs e)
        {
            Button leftBracket = (Button)sender;
            textBox1.Text += leftBracket.Text;
        }

        private void rightBracket_Click(object sender, EventArgs e)
        {
            Button rightBracket = (Button)sender;
            textBox1.Text += rightBracket.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Button clearButton = (Button)sender;
            textBox1.Text = "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                textBox1.Text = "";
            } else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
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
            char[] delimiter = { '+', '-', '*', '/' };
            
            string[] strSplit = EquationSpliter(textBox1.Text, delimiter, 0);
            double result = 0;

            result = ArrayCalculator(strSplit, '+');

            textBox1.Text += Environment.NewLine + Convert.ToString(result);

            /*
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
            */
        }

        /*
         * 식의 구성요소를 계산해주는 함수
         */
        private double ArrayCalculator(string[] expression, char delimiter)
        {
            double result = 0;

            for (int i=0; i<expression.Length; i++)
            {
                if (i == 0)
                {
                    result = Convert.ToDouble(expression[i]);       // 첫번째 피연산자는 그대로 담는다.
                } else
                {
                    switch (delimiter)
                    {
                        case '+':
                            result += Convert.ToDouble(expression[i]);
                            break;
                        case '-':
                            result -= Convert.ToDouble(expression[i]);
                            break;
                        case '*':
                            result *= Convert.ToDouble(expression[i]);
                            break;
                        case '/':
                            result /= Convert.ToDouble(expression[i]);
                            break;
                    }
                }
            }
            return result;
        }

        /*
         * 주어진 식으로부터 배열을 만드는 함수
         */
        private string[] EquationSpliter(string equation, char[] delimiter, int delimiterCount)
        {
            int delimiterCountTemp = delimiterCount;
            int delimiterLength = delimiter.Length;
            string[] strSplit = equation.Split(delimiter[delimiterCount]);
            string[] strSubSplit;
            bool splitIsNum = false;

            for (int i=0; i<strSplit.Length; i++)
            {
                double splitNum = 0;
                splitIsNum = double.TryParse(strSplit[i], out splitNum);
                if (!splitIsNum)
                {
                    if (delimiterCountTemp < delimiterLength)
                    {
                        delimiterCountTemp++;
                    }
                    strSubSplit = EquationSpliter(strSplit[i], delimiter, delimiterCountTemp);
                    splitNum = ArrayCalculator(strSubSplit, delimiter[delimiterCountTemp]);
                }

                delimiterCountTemp = delimiterCount;
                strSplit[i] = Convert.ToString(splitNum);
            }

            return strSplit;
        }
    }
}
