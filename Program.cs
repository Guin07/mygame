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
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, игрок. Сколько у Вас карт на руках?");
            int summ = 0;
            int x = int.Parse(Console.ReadLine());
            int[] cards = new int[x];
            
            Console.WriteLine("Введите номинал каждой карты:");
            string card = Console.ReadLine();
            for (int i = 0; i < x; i++)
                card = Console.ReadLine();
            {                   
                switch (card)
                {
                    case "T":
                        summ += 10;
                        break;
                    case "K":
                        summ += 10;
                        break;
                    case "Q":
                        summ += 10;
                        break;
                    case "J":
                        summ += 10;
                        break;
                    case "10":
                        summ += 10;
                        break;
                    case "9":
                        summ += 9;
                        break;
                    case "8":
                        summ += 8;
                        break;
                    case "7":
                        summ += 7;
                        break;
                    case "6":
                        summ += 6;
                        break;
                    case "5":
                        summ += 5;
                        break;
                    case "4":
                        summ += 4;
                        break;
                    case "3":
                        summ += 3;
                        break;
                    case "2":
                        summ += 2;
                        break;
                    default:
                        Console.WriteLine("Таких карт не существует");
                        break;
                 }                
            } 
            if (summ == 21) Console.WriteLine("Поздравляем - Вы выиграли!");
            else if (summ > 21) Console.WriteLine("Вы сгорели!");
            else Console.WriteLine("Недобор!");
         }              
    }
}
