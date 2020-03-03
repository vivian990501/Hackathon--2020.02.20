using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入年收入:");
            decimal minutes = decimal.Parse(Console.ReadLine());
            //Console.WriteLine(income.ToString());
            Console.WriteLine(MoneyCalculator_1.GetParkingFee(minutes).ToString());
            Console.ReadLine();
        }
    }
}
