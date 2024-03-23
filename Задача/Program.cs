using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);
            Console.ReadKey();
        }
        static void Factorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i < n+1; i++)
            {
                factorial *= i;
                Thread.Sleep(100);
            }
            Console.WriteLine(factorial);
        }
        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
