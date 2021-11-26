using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._1
{
    class Program
    {
        public static int N { get; private set; }

        static void Main(string[] args)
            
        {
            int count = 2;
            

            Console.WriteLine("Введите целое число: ");
            int n = (int)double.Parse(Console.ReadLine());
            
            while (count < n)

            {
                if (n % 2 == 1) 
                {
                    Console.WriteLine("Это простое число!"); 
                    count++;
                }

                else if (n % 2 == n)
                {
                    Console.WriteLine("Это простое число!");
                    count++;
                }

                else
                {
                    Console.WriteLine("Это не простое число!");
                    count++;
                }
                break;
            }
        }
    }
}
