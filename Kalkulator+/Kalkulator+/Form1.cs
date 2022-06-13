using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_
{
    public partial class Form1 : Form
    {
        float memory = 0;
        string temp = "";
        bool aftsign = false;
        string sign;
        bool chck;     
        void CA()
        {
            temp = "";
            memory = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            signable(false);
            numerable(true);
            sign = " +";
            aftsign = false;
            chck = true;

        }
        void newchck()
        {
            if (chck == true)
            {
                textBox2.Text = "";
                temp = "";
                aftsign = false;
            }
        }

        void hstrdisp()
        {
            if (aftsign == true)
            {
                textBox2.Text = textBox2.Text + textBox1.Text + " ";
                textBox1.Text = "";
            }
        }

        void number(string num)
        {
            temp = temp + num;
            hstrdisp();
            textBox1.Text = textBox1.Text + num;
            aftsign = false;
            signable(true);
            chck = false;
        }

        void memorywrite()
        {
            if (sign == " *")
            {
                memory = memory * Convert.ToSingle(temp);
            }
            else if (sign == " /")
            {
                memory = memory / Convert.ToSingle(temp);
            }
            else if (sign == " +")
            {
                memory = memory + Convert.ToSingle(temp);
            }
            else if (sign == " -")
            {
                memory = memory - Convert.ToSingle(temp);
            }
        }

        void signing(string sn)
        {
            newchck();
            hstrdisp();
            memorywrite();
            temp = "";
            sign = sn;
            textBox1.Text = textBox1.Text + sn;
            aftsign = true;
            signable(false);
            chck = false;
            numerable(true);
        }
        void numerable (bool state)
        {
            button1.Enabled = state;
            button2.Enabled = state;
            button3.Enabled = state;
            button4.Enabled = state;
            button5.Enabled = state;
            button6.Enabled = state;
            button7.Enabled = state;
            button8.Enabled = state;
            button9.Enabled = state;
            button10.Enabled = state;
            button11.Enabled = state;
        }
        void signable (bool state)
        {
            button11.Enabled = state;
            button12.Enabled = state;
            button13.Enabled = state;
            button14.Enabled = state;
            button15.Enabled = state;
            button17.Enabled = state;
        }

        public Form1()
        {
            InitializeComponent();
            signable(false);
            sign = " +";
            aftsign = false;
            chck = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {;
            number("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            number("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            number("0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            signing(" +");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            signing(" -");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            signing(" *");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            signing(" /");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            temp = temp + ",";
            hstrdisp();
            textBox1.Text = textBox1.Text + ",";
            signable(false);
            chck = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            aftsign = true;
            memorywrite();
            hstrdisp();
            sign = "+";
            textBox1.Text = memory.ToString();
            signable(true);
            numerable(false);
            chck = true;        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {            
            if (chck == true)
            {
                CA();
                chck = false;
            }
            else
            {
                textBox1.Text = "";
                temp = "";
                signable(false);
                aftsign = true;
            }            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            CA();
        }
    }
}
