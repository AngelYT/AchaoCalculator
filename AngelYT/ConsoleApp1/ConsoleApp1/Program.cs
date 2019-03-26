using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("需要打印的题目数量：");
            int n = int.Parse(Console.ReadLine());
            Random rd = new Random();
            
            for (int i=0;i<n;i++)
            {
                int num1 = rd.Next(1, 100);
                int num2 = rd.Next(1, 100);
                int value = 0;
                int num3 = rd.Next(0, 10);
                if (num3 == 1)
                {
                    value = num1 + num2;
                    Console.WriteLine(num1 + "+" + num2 + "=" + value);
                }                   
                else if (num3 == 2)
                {
                    value = num1 - num2;
                    Console.WriteLine(num1 + "-" + num2 + "=" + value);
                }                   
               else if (num3 == 3)
                {
                    value = num1 * num2;
                    Console.WriteLine(num1 + "*" + num2 + "=" + value);
                }                   
                else
                {
                    value = num1 / num2;
                    if (num1 % num2==0)
                    Console.WriteLine(num1 + "/" + num2 + "=" + value);
                    else
                    {
                        value = num1 * num2;
                        Console.WriteLine(num1 + "*" + num2 + "=" + value);
                    }
                        

                }                                  
            }Console.ReadKey();
            
        }
       
    }
}
