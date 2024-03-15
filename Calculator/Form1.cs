using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double fn;
        string op;  
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "/";  
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "*";  
        }

        private void button12_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op= "-";  
        }

        private void button16_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "+";  
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";  
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double sn;
            double res;

            sn = Convert.ToDouble(textBox1.Text);

            if (op == "+")
            {
                res = (fn + sn);
                textBox1.Text = Convert.ToString(res);
                fn = res;
            }
            if (op == "-")
            {
                res = (fn - sn);
                textBox1.Text = Convert.ToString(res);
                fn = res;
            }
            if (op == "*")
            {
                res = (fn * sn);
                textBox1.Text = Convert.ToString(res);
                fn = res;
            }
            if (op == "/")
            {
                if (sn == 0)
                {
                    textBox1.Text = "can't divide by zero";

                }
                else
                {
                    res = (fn / sn);
                    textBox1.Text = Convert.ToString(res);
                    fn = res;
                }
            }
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
