using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon__2
{//http://www.ezonesoft.com.tw/S1/PDF/C05.pdf
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true; ;
        }
        //F = 9/5 * C + 32 
        //C = (F - 32) * 5/9
        private void button1_Click(object sender, EventArgs e)
        {
            string i = "1";
            label2.Text+= i;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string i = "2";
            label2.Text += i;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string i = "3";
            label2.Text += i;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string i = "4";
            label2.Text += i;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string i = "5";
            label2.Text += i;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string i = "6";
            label2.Text += i;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string i = "7";
            label2.Text += i;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string i = "8";
            label2.Text += i;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string i = "9";
            label2.Text += i;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string i = "0";
            label2.Text += i;

            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string i = ".";
            if (label2.Text.IndexOf(".") < 0)
            {
                label2.Text += i;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
               double C = double.Parse(label2.Text);
                double F = 9.0 / 5 * C  + 32;
                F = Math.Round(F, 3);
                label1.Text = $"結果 : {C}°C = {F}°F";
            }
            else
            {
                double F = double.Parse(label2.Text);
                double C = (F - 32) * 5 / 9;
                C = Math.Round(C, 3);
                label1.Text = $"結果 : {F}°F = {C}°C";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label2.Text = null;
            label1.Text = null;
        }
    }
}
