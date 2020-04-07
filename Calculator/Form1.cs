﻿using System;
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
            AddToTextbox("1");
        }

        private void number2_Click(object sender, EventArgs e)
        {
            AddToTextbox("2");
        }

        private void number3_Click(object sender, EventArgs e)
        {
            AddToTextbox("3");
        }

        private void number4_Click(object sender, EventArgs e)
        {
            AddToTextbox("4");
        }

        private void number5_Click(object sender, EventArgs e)
        {
            AddToTextbox("5");
        }

        private void number6_Click(object sender, EventArgs e)
        {
            AddToTextbox("6");
        }

        private void number7_Click(object sender, EventArgs e)
        {
            AddToTextbox("7");
        }

        private void number8_Click(object sender, EventArgs e)
        {
            AddToTextbox("8");
        }

        private void number9_Click(object sender, EventArgs e)
        {
            AddToTextbox("9");
        }

        private void number0_Click(object sender, EventArgs e)
        {
            AddToTextbox("0");
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

        private void divide_Click(object sender, EventArgs e)
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

        public void AddToTextbox(string a)
        {
            textBox1.Text += a;
        }


    }
}