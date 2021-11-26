using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Program
    {
        private static object primes;

        void SieveOfEratosthenes(int n)
        {
            bool[] primes = new bool[n + 1];
            {
                Console.WriteLine("Введите целое число: ");
                int N = (int)double.Parse(Console.ReadLine());
                if (N==1) Console.WriteLine("Число является простым!");
                {
                    for (int i = 0; i < N; i++)
                        primes[i] = true;
                }
                
                else if (N==0) Console.WriteLine("Число не является простым!");
                {
                    for (int i = 2; i * i <= N; i++)
                        if (primes[i])
                            for (int j = i * 2; j <= n; j += i)
                                primes[j] = false;
                }
                
                else if (N==) Console.WriteLine("Число не является простым!");
                {
                    for (int i = 2; i <= N; i++)
                        if (primes[i]) Console.Write(i + " ");
                }
                
            }
        }
    }
}
