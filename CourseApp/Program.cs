using System;

namespace CourseApp
{
    public class Program
    {
        public static double function(double x, double b)
        {
            double y;
            y = (1+Math.Pow(Math.Sin(Math.Pow(b,3)+Math.Pow(x,3)),2))/ Math.Pow((Math.Pow(b, 3) + Math.Pow(x, 3)),(1.0/3));
            return y;
        }



        public static void Main(string[] args)
        {

            Console.WriteLine("Вариант 1");

            double b = 2.5;
            double[] numbers = new double[5] {1.1, 2.4, 3.6, 1.7, 3.9};

            Console.WriteLine("ЗАДАНИЕ А");

            double x1 = 1.28; //x начальное
            double x2 = 3.28; //x конечное
            double dx = 0.4;

            double i = x1;
            while(i<=x2)
            {
                Console.WriteLine($"x={i}  y={Math.Round(function(i,b),3)}");
                i = i + dx;
            }

            Console.WriteLine("ЗАДАНИЕ Б");

            foreach(double j in numbers)
            {
                Console.WriteLine(Math.Round(function(j,b),3));
            }
            
            Console.WriteLine(" \nкошачье досье \n ");
            
            Cat Tom = new Cat();  //вызов 1-го конструктора
            Cat Red = new Cat("Рыжик",6); //вызов 2-го конструктора 
            Cat Begemot = new Cat("Бегемот","черный");  //вызов 3-го конструктора

            Tom.GetInfo();
            Red.GetInfo();
            Begemot.GetInfo();

            Tom.Age = 6;    //день рождения Тома
            Console.WriteLine($"возраст Тома - {Tom.Age} лет"); //получить возраст Тома

            string Word = Tom.Meow();
            Console.WriteLine(Word);
            string AskiCat = Tom.Kotik();
            Console.WriteLine(AskiCat);
        }



    }
}
