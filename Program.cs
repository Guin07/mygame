using System;

namespace По_заказу
{
    class Program
    { //переменные, которые будут использоваться для обозначения данных

        private static double height;
        private static string fullname;
        private static double russianlanguagescores;
        private static double historyscores;
        private static double mathscores;
        private static string answer;
        private static int topRightX;
        private static bool centerText;

        public static byte age { get; private set; }

        static void Main()

        {
            //отображение данных

            Console.WriteLine("Введите имя: "); //переменная, обозначающая имя
            fullname = Console.ReadLine();

            Console.WriteLine("Введите возраст: "); //переменная, обозначающая возраст
            age = byte.Parse(Console.ReadLine());

            Console.WriteLine("Введите Ваш рост: "); //переменная, обозначающая рост
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите Ваши баллы по русскому языку: "); //переменная, обозначающая баллы за русский язык
            russianlanguagescores = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите Ваши баллы по математике: "); //переменная, обозначающая баллы за математику
            mathscores = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите Ваши баллы по истории: "); //переменная, обозначающая баллы за историю
            historyscores = double.Parse(Console.ReadLine());

            double valueA = russianlanguagescores; double valueB = mathscores; double valueC = historyscores; //расчёт среднего арифметического из общего количества баллов
            double valueD = valueA + valueB + valueC;
            double valueE = 3;
            var valueF = valueD / valueE;

            string newpattern_2 = "{0} \n"; //вывод ответа расчёта 

            Console.WriteLine("Посчитать среднее арифметическое Ваших баллов? "); //переменная, обозначающая ответ за среднее арифметическое
            answer = Console.ReadLine();

            Console.WriteLine(newpattern_2, //сам ответ
                valueF);

            Console.ReadKey();
        }

    }
    
}
