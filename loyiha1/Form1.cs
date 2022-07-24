using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loyiha1
{
    public partial class Form1 : Form
    {
        float a, b, d;
        int amal,  g = 1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "0" )
            {
                textBox1.Text = textBox1.Text + "0";
            }
           
            else
            {
                textBox1.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
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
            if (textBox1.Text == "0")
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
            if (textBox1.Text == "0")
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
            if (textBox1.Text == "0")
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
            if (textBox1.Text == "0")
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
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0.";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox1.Clear();
            g = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            amal = 2;
            textBox1.Text = "0";
            g = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            amal = 3;
            textBox1.Text = "0";
            g = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            b = float.Parse(textBox1.Text); textBox1.Text = Math.Sqrt(b).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Text = (a * (-1)).ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBox1.Text = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            textBox1.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            amal = 4;
            textBox1.Text = "0";
            g = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            amal = 1;
            textBox1.Text = "0";
            g = 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hisoblash();
            
        }

        private void hisoblash()
        {
           
            switch(amal)
            {
                case 1: b = float.Parse(textBox1.Text);
                    d = (a + b);
                    textBox1.Text = d.ToString();
                    if(g == 1)
                    {
                        a = (float.Parse(textBox1.Text) - a);
                        g++;
                    }
                    else
                    {
                        a = (float.Parse(textBox1.Text) - b);
                        g++;
                    }
                    break;
                case 2:
                    if (g == 1)
                    {
                        b = float.Parse(textBox1.Text);
                        d = (a - b);
                        textBox1.Text = d.ToString();
                        g++;
                    }
                    else
                    {
                        a = float.Parse(textBox1.Text);
                        d = (a - b);
                        textBox1.Text = d.ToString();
                        b = (a - float.Parse(textBox1.Text));
                        g++;
                    }
                    
                    break;
                case 3:
                    b = float.Parse(textBox1.Text);
                    d = (a * b);
                    textBox1.Text = d.ToString();
                    if (g == 1)
                    {
                        a = (float.Parse(textBox1.Text) / a);
                        g++;
                    }
                    else
                    {
                        a = (float.Parse(textBox1.Text) / b);
                        g++;
                    }
                    break;
                case 4:
                    if (g == 1)
                    {
                        b = float.Parse(textBox1.Text);
                        d = (a / b);
                        textBox1.Text = d.ToString();
                        g++;
                    }
                    else
                    {
                        a = float.Parse(textBox1.Text);
                        d = (a / b);
                        textBox1.Text = d.ToString();
                        b = (a / float.Parse(textBox1.Text));
                        g++;
                    }
                    break;
            }
        }
    }
}
