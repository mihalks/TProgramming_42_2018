using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Formula(double x)
        {
            double y = (Math.log(Math.Abs(Math.Pow(1.1, 2) - Math.Pow(x, 2))) / Math.Pow(Math.Abs(Math.Pow(x, 2) - Math.Pow(2.0, 2)), 0.2);          
            Console.WriteLine($"При начальном и конечном х = {x} функция y = {Math.Round(y, 4)}");
        }
        static void Main()
        {
            Console.WriteLine("1 вариант");
            for (double x = 0.08; x <= 1.08; x = x + 0.2)
            {
                Formula(x);
            }
            Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}