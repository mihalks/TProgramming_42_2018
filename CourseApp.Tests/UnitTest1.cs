using System;
using Xunit; 
using ConsoleApp1;


namespace CourseApp.Tests
{
    public class UnitTest1
    {
        double a = 2.0;
        double b = 1.1;
        double x1 = 0.08;
        double x2 = 1.08;
        double dx = 0.2;
        double[] z = new double[5] { 0.1, 0.3, 0.4, 0.45, 0.65 };
        [Fact]
        public void Test1()
        {
            double y = Program.Formula(0.1, 2.0, 1.1);
            Assert.Equal(0.138, y, 3);
        }
        [Fact]
        public void Test2()
        {
            double y = Program.Formula(0, 2.0, 1.1);
            Assert.Equal(0.144, y, 3);
        }
        [Fact]
        public void Test3()
        {
            double y = Program.Formula(0.1, 0, 1.1);
            Assert.Equal(-0.025, y, 3);
        }
        [Fact]
        public void Test4()
        {
            double y = Program.Formula(0.1, 2.0, 0);
            Assert.Equal(-3.492, y, 3);
        }

        [Fact]
        public void test5()
        {
            double[] mas = new double[5] { 0.138, 0.086, 0.037, 0.006, -0.185 };
            for (int i = 0; i < mas.Length; i++)
            {
                var y = Program.Formula(z[i],2.0, 1.1);
                Assert.Equal(mas[i], y, 3);
            }
        }
        [Fact]
        public void test6()
        {
            int i = 0;
            double[] mas = new double[6] { 0.140, 0.094, -0.016, -0.226, -0.657, -2.544 };
            for (double j = x1; j <= x2; j += dx)
            {
                var y = Program.Formula(j, 2.0, 1.1);
                Assert.Equal(mas[i], y, 3);
                i++;
            }
        }
        [Fact]
        public void test7()
        {
            Country tom = new Country();
            var people = tom.people;
            var s = tom.s;
            var name = tom.name;

            Assert.Equal(24140800, people);
            Assert.Equal(7692024, s);
            Assert.Equal("Australiya", name);

        }
        [Fact]
        public void test8()
        {
            Country dom = new Country(146880432, 17125191, "Russia");
            var people = dom.people;
            var s = dom.s;
            var name = dom.name;

            Assert.Equal(146880432, people);
            Assert.Equal(17125191, s);
            Assert.Equal("Russia", name);

        }
        [Fact]
        public void test9()
        {
            Country bom = new Country(30316, 12.6);
            var people = bom.people;
            var s = bom.s;
            var name = bom.name;

            Assert.Equal(30316, people);
            Assert.Equal(12.6, s);
            Assert.Equal("Kohma", name);

        }

        [Fact]
        public void Test10()
        {
            Country bom = new Country();
            var name = bom.name;
            Assert.Equal("Australiya", name);
            string Word = $"Strana {name} skasala: \'Dhou!\', a mne nado pomenyat dillera";
            Assert.Equal($"Strana Australiya skasala: \'Dhou!\', a mne nado pomenyat dillera", Word);
        }
    }
}
