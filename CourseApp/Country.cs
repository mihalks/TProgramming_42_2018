using System;

namespace ConsoleApp1
{
    public class Country
    {
        private int people;

        public Country()
            : this(24140800, 7692024)
        {
            Name = "Australiya";
        }

        public Country(int a, float b)
            : this(a, b, "Kohma")
        {
        }

        public Country(int people, float square, string name)
        {
            People = people;
            Square = square;
            Name = name;
        }

        public float Square { get; set; }

        public string Name { get; set; }

        public int People
        {
            get
            {
                return people;
            }

            set
            {
                if (value > 0)
                {
                    this.people = value;
                }
            }
        }

        public void GetInfo()
        {
            Console.WriteLine("Земля - страна");
            Console.WriteLine($"Имя: {Name}, население: {People}, площадь: {Square} ");
            Console.WriteLine(Voice());
        }

        public override string ToString()
        {
            return $"Страна {Name} находится в Евразии";
        }

        public string Voice()
        {
            return $"Страна {Name} сказала \'Dhou!\', погружаясь в лаву";
        }
    }
    }