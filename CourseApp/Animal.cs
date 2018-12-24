using System;

namespace CourseApp
{
    public abstract class Animal
    {
        private string name;

        private float age;

        private string color;

        public Animal()
        {
            Name = "NoName";
            Age = 0;
            Color = "NoColor";
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value != null)
                {
                    this.name = value;
                }
            }
        }

        public float Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value > 0)
                {
                    this.age = value;
                }
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                if (value != null)
                {
                    this.color = value;
                }
            }
        }

    public abstract void Display();

    public abstract string Voice();
    }
}