using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon__3
{
    public partial class Form1 : Form
    {
        int[] answer = new int[4];
        int[] reply = new int[4];
        string answer_s;
        public Form1()
        {
            InitializeComponent();
        }
        private void GameStart()
        {
            
            var rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                answer[i] = rnd.Next(1, 10);
                for (int j = 0; j < i; j++)
                {
                    while (answer[j] == answer[i])
                    {
                        j = 0;
                        answer[i] = rnd.Next(1, 10);
                    }
                }
            }

        }
        private void ShowAnswer()
        {
            foreach (int i in answer)
            {
                answer_s = answer_s + i.ToString();
            }
        }
        private void Judge_1()
        {
            //substring抓一個一個字
            int a = 0;
            int b = 0;
            int reply_i = int.Parse(textBox1.Text);
            reply[0] = reply_i / 1000;
            reply[1] = (reply_i - (reply[0] * 1000)) / 100;
            reply[2] = (reply_i - (reply[0] * 1000) - (reply[1] * 100)) / 10;
            reply[3] = (reply_i - (reply[0] * 1000) - (reply[1] * 100)) % 10;
            for (int i = 0; i < 4; i++)
            {
                if (reply[i] == answer[i])
                {
                    a++;
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (answer[j] == reply[i])
                        {
                            b++;
                        }
                    }
                }
            }
            listBox1.Items.Add($"{reply_i} {a}A{b}B");
            if (a == 4)
            {
                MessageBox.Show("通關");
                Reset();
            }
        }
        private void Judge_2()
        {
            string answer_y = textBox1.Text;
            var intersect = answer_s.Intersect(answer_y);
            var countofA = intersect.Count((x) => answer_s.IndexOf(x) == answer_y.IndexOf(x));
            var countofB = intersect.Count() - countofA;
            listBox1.Items.Add($"{answer_y} {countofA}A{countofB}B");
            if (countofA == 4)
            {
                MessageBox.Show("通關");
                Reset();
            }
        }
       private void Reset()
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            answer_s = null;
            button1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GameStart();
            ShowAnswer();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(answer_s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Judge_1();
            Judge_2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            answer_s = null;
            button1.Enabled = true;
        }
    }
}
