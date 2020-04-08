using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Calc;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double tmp1, tmp2;
        ICalc Calc;

        public Form1()
        {
            InitializeComponent();
        }

        private void number1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                AddToTextbox("1");
            }
        }

        private void number2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                AddToTextbox("2");
            }
        }

        private void number3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                AddToTextbox("3");
            }
        }

        private void number4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                AddToTextbox("4");
            }
        }

        private void number5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                AddToTextbox("5");
            }
        }

        private void number6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                AddToTextbox("6");
            }
        }

        private void number7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                AddToTextbox("7");
            }
        }

        private void number8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                AddToTextbox("8");
            }
        }

        private void number9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text  != "0" )
            {
                AddToTextbox("9");
            }
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                AddToTextbox("0");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmp1 = 0;
            tmp2 = 0;
            Calc = null;
            textBox1.Text  = "";
            textBox2.Text  = "";
            
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Calc != null)
                {
                    tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(textBox1.Text));
                    
                }
                else
                {
                    tmp1 =  Convert.ToDouble(textBox1.Text);
                }
                textBox1.Text = "";
                textBox2.Text = tmp1 + "";
                Calc = new Adder();
               ;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                    if (Calc != null)
                    {
                        tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(textBox1.Text));

                    }
                    else
                    {
                        tmp1 = Convert.ToDouble(textBox1.Text);
                    }
                textBox1.Text = "";
                textBox2.Text = tmp1 + "";
                Calc = new Substractor();
            }

            else
            {
                textBox1.Text = "-";
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Calc != null)
                {
                        tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(textBox1.Text));
                }
                else
                {
                    tmp1 = Convert.ToDouble(textBox1.Text);
                }
                
                textBox1.Text = "";
                textBox2.Text = tmp1 + "";
                Calc = new Multiplicator();
            }
        }

        private void divide_Click(object sender, EventArgs e)   //деление на 0
        {
            if (textBox1.Text != "")
            {
                if (Calc != null)
                {
                        tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(textBox1.Text));
                    

                }

                else
                {
                    tmp1 = Convert.ToDouble(textBox1.Text);
                }
                textBox1.Text = "";
                textBox2.Text = tmp1 + "";
                Calc = new Divider();
            }

           
        }

        private void solve_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != ""&& Calc !=null)
            {
                tmp2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Calc.DoMath(tmp1, tmp2) + "";
                textBox2.Text = textBox1.Text ;
            }
        }

        private void comma_Click(object sender, EventArgs e)   //как убрать две запятые подряд
        {
            if (textBox1.Text != "")
            {
                if (Convert.ToDouble(textBox1.Text) % 1 == 0 )
                {
                    textBox1.Text = textBox1.Text + ",";
                }
            }

            else 
            {
                textBox1.Text = textBox1.Text + "0,";
            }
            
        }

        private void changeSign_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > 0)
            {
                textBox1.Text = "-"+ Convert.ToDouble(textBox1.Text);
            }

            else
            {
                textBox1.Text = Convert.ToDouble(textBox1.Text) * -1+ "" ;      
               // textBox1.Text = tmp1 + "";
            }
           

        }

        public void AddToTextbox(string a)
        {
            textBox1.Text += a;
        }


    }
}
