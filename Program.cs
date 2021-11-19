using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашняя_работа__3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");  //переменная, обозначающая число
            int b = (int)double.Parse(Console.ReadLine());
            Console.WriteLine($"Это число...{ b}");
            if (b % 2 == 0) ;
            {
                Console.WriteLine("...является чётным");
            }
            else (b % 2 != 0);
            {
                Console.WriteLine("...является нечётным");
            }
                      
        }
    }
}
