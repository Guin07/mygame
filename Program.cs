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
            int n = int.Parse(Console.ReadLine());

            while (count < n)

            {
                if (n % count >= 1)
                {
                    Console.WriteLine($"Это число {n} не поделилось на {count}! Оно является простым.");
                    
                }

                else if (n % count == 0)
                {
                    Console.WriteLine($"Это число {n} поделилось на {count}! Оно не является простым.");
                    
                }
                count++;

            } Console.ReadKey();
        }
    }
    
}
