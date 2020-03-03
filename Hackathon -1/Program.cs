using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon__1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {

                    string x = i.ToString();
                    x = x.Replace('3', 'A')
                         .Replace('5', 'B')
                         .Replace('9', 'C')
                         .Replace('0', 'D');
                    Console.WriteLine(x);

                
            }
            Console.ReadLine();
        }
    }
}
