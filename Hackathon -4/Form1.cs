using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon__4
{
    public partial class Form1 : Form
    {
        private List<LifeSpirits> Data { get; set; }
        int birth_d ;
        int birth_m ;
        int birth_y;
        int sum;
        
        public Form1()
        {
            InitializeComponent();
            Data = LifeSpirits_Data.GetDataList();
        }

        private void MathSum()
        {
            sum = 0;
            string birth_s = birth_y.ToString() + birth_m.ToString() + birth_d.ToString();
            //label3.Text = birth_s;
            //label3.Text = birth_s.Count().ToString();
            for (int i = 0; i < birth_s.Count(); i++)
            {
                sum += int.Parse(birth_s.Substring(i, 1));
            }
            label1.Text = sum.ToString();
            while (sum>9)
            {
                string sum_s = sum.ToString();
                sum = 0;

                for (int i = 0; i < sum_s.Count(); i++)
                {
                    sum += int.Parse(sum_s.Substring(i, 1));
                    
                }
            }
            
        }
        private void FindData(int birth_m)
        {
            LifeSpirits data;
           switch (birth_m)
            {
                case 1:
                    if (birth_d >= 1 && birth_d <= 20)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x)=>x.Constellation=="摩羯座" && x.ID==sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    else if (birth_d >= 21 && birth_d <= 31)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "水瓶座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    break;
                case 2:
                    if (birth_d >= 1 && birth_d <= 19)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "水瓶座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    else if (birth_d >= 20 && birth_d <= 29)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "雙魚座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    break;
                case 3:
                    if (birth_d >= 1 && birth_d <= 20)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "雙魚座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";

                    }
                    else if (birth_d >= 21 && birth_d <= 31)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "牧羊座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    break;
                case 4:
                    if (birth_d >= 1 && birth_d <= 20)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "牧羊座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    else if (birth_d >= 21 && birth_d <= 30)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "金牛座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    break;
                case 5:
                    if (birth_d >= 1 && birth_d <= 21)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "金牛座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    else if (birth_d >= 22 && birth_d <= 31)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "雙子座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    break;
                case 6:
                    if (birth_d >= 1 && birth_d <= 22)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "雙子座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    else if (birth_d >= 23 && birth_d <= 30)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "巨蠍座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    break;
                case 7:
                    if (birth_d >= 1 && birth_d <= 24)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "巨蠍座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    else if (birth_d >= 25 && birth_d <= 31)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "獅子座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    break;
                case 8:
                    if (birth_d >= 1 && birth_d <= 23)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "獅子座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    else if (birth_d >= 24 && birth_d <= 31)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "處女座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    break;
                case 9:
                    if (birth_d >= 1 && birth_d <= 23)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "處女座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    else if (birth_d >= 24 && birth_d <= 30)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "天秤座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    break;
                case 10:
                    if (birth_d >= 1 && birth_d <= 23)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "天秤座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    else if (birth_d >= 24 && birth_d <= 31)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "天蠍座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    break;
                case 11:
                    if (birth_d >= 1 && birth_d <= 22)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "天蠍座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    else if (birth_d >= 23 && birth_d <= 30)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "射手座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    break;
                case 12:
                    if (birth_d >= 1 && birth_d <= 22)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation =="射手座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    else if (birth_d >= 23 && birth_d <= 31)
                    {
                        MathSum();
                        data = LifeSpirits_Data.GetDataList().FirstOrDefault((x) => x.Constellation == "摩羯座" && x.ID == sum);
                        label2.Text = $"你的星座是 {data.Constellation}";
                        label3.Text = $"你的{data.Spirit}";
                    }
                    break;
                default:
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birth = new DateTime(dateTimePicker1.Value.Ticks);
             birth_d = birth.Day;
             birth_m = birth.Month;
             birth_y = birth.Year;
            FindData(birth_m);
            
            //label2.Text =birth_d.ToString();

        }
    }
}
