
using System;

namespace ConsoleApp1
{
    public class Country
    {
        public int people;
        public double square { get; set; }
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


        public Country() {people = 24140800; square = 7692024; name = "Australiya"; }      

        public Country(int a, double b, string n) { people = a; square = b; name = n; }         

        public Country(int a, double b) { people = a; square = b; name = "Kohma"; }         

        public void GetInfo()
        {
            Console.WriteLine($"Население:{people} Площадь:{square}  название страны: {name}");
        }
                public string Dhou() 
        {
            return $"Strana {name} skasala: \'Dhou!\', a mne nado pomenyat dillera";
        }
    }


    }

