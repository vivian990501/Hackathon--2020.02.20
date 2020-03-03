using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon__5
{
    class Program
    {
        static void Main(string[] args)
        {
            //算小於等於平方根的數字會被會被整除就知道是不是質數了
            
            for (int i = 101; i<=200;i++)
            {
                for (int k = 2; k<=i;k++)
                {
                    if(i%k==0 && i !=k)// 排除所有在 i=k 之前 能被k整除(餘數為0)的數
                    {
                        break;
                    }
                    if (i % k == 0 && i == k)// 輸出所有在 i=k 且 i%k=0的數
                    {
                        
                        Console.WriteLine(i);
                    }
                }
               
            }
            Console.ReadLine();
        }
    }
}
