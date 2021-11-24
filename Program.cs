using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    class Program
    {
        private static int sum;
       
        public static int T { get; private set; }
        public static int K { get; private set; }
        public static int Q { get; private set; }
        public static int J { get; private set; }
       
        
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, игрок. Сколько у Вас карт на руках?");
            int summ = 0;
            int x = int.Parse(Console.ReadLine());
            int[] cards = new int[x];
            
            //Console.Clear();
            Console.WriteLine("Введите номинал каждой карты:");
            string card = Console.ReadLine();
            for (int i = 0; i < x; i++)
            {                   
                switch (card)
                {
                    case "T":
                        sum += 10;
                        break;
                    case "K":
                        sum += 10;
                        break;
                    case "Q":
                        sum += 10;
                        break;
                    case "J":
                        sum += 10;
                        break;
                    case "10":
                        sum += 10;
                        break;
                    case "9":
                        sum += 9;
                        break;
                    case "8":
                        sum += 8;
                        break;
                    case "7":
                        sum += 7;
                        break;
                    case "6":
                        sum += 6;
                        break;
                    case "5":
                        sum += 5;
                        break;
                    case "4":
                        sum += 4;
                        break;
                    case "3":
                        sum += 3;
                        break;
                    case "2":
                        sum += 2;
                        break;
                    default:
                        Console.WriteLine("Таких карт не существует");
                        break;

                        summ += int.Parse(Console.ReadLine());
                        if (summ == 21) Console.WriteLine("Поздравляем - Вы выиграли!");
                        else if (summ > 21) Console.WriteLine("Вы сгорели!");
                        else Console.WriteLine("Недобор!");
                }
               
                

                Console.ReadKey();

           
            }
          
        }

        
    }
}
