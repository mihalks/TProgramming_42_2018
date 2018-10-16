using System;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вариант 1");
            double function(double x )
            {
                double b = 2.5;
                double y;
                y = (1+Math.Pow(Math.Sin(Math.Pow(b,3)+Math.Pow(x,3)),2))/ Math.Pow((Math.Pow(b, 3) + Math.Pow(x, 3)),(1.0/3));
                return y;
            }

            double[] numbers = new double[5] {1.1, 2.4, 3.6, 1.7, 3.9};
            Console.WriteLine("ЗАДАНИЕ А");

            double i = 1.28;
            while(i<=3.28)
             {
                 Console.WriteLine(function(i));
                 i = i + 0.4;
             }

            Console.WriteLine("ЗАДАНИЕ Б");


            for (int j=0;j<5;j++)
             {
                numbers[j] = function(numbers[j]);
             }

            for (int j = 0; j < 5; j++)
             {
                 Console.WriteLine(numbers[j]);
             }
            
        }
    }
}
