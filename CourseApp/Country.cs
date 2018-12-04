
using System;

namespace ConsoleApp1
{
    public class Country
    {
        public int people;
        public double s { get; set; }
        public string name { get; set; }

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


        public Country() {people = 24140800; s = 7692024; name = "Australiya"; }      

        public Country(int a, double b, string n) { people = a; s = b; name = n; }         

        public Country(int a, double b) { people = a; s = b; name = "Kohma"; }         

        public void GetInfo()
        {
            Console.WriteLine($"Население:{people} Площадь:{s}  название страны: {name}");
        }
                public string Dhou() 
        {
            return $"Strana {name} skasala: \'Dhou!\', a mne nado pomenyat dillera";
        }
    }


    }

