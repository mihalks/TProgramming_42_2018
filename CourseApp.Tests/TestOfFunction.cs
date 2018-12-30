using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestOfFunction
    {
        private double x1 = 1.28; // x ���������
        private double x2 = 3.28; // x ��������
        private double dx = 0.4;
        private double[] numbers = new double[5] { 1.1, 2.4, 3.6, 1.7, 3.9 };

        [Fact]
        public void Function1()
        {
            double y = Program.Function(1.1, 2.5 );
            Assert.Equal(0.739, y, 3 );
        }

        [Fact]
        public void Function2()
        {
            double y = Program.Function(0, 2.5 );
            Assert.Equal(0.403, y, 3 );
        }

        [Fact]
        public void Function3()
        {
            double y = Program.Function(1.1, 0);
            Assert.Equal(1.767, y, 3 );
        }

        [Fact]
        public void Function4()
        {
            double y = Program.Function(0.0, 0.0 );
            Assert.Equal(double.PositiveInfinity, y, 3 );
        }

        [Fact]
        public void Function5()
        {
            double[] mas = new double[5] { 0.739, 0.599, 0.321, 0.725, 0.283 };
            for (int i = 0; i < mas.Length; i++)
            {
                var y = Program.Function(numbers[i], 2.5 );
                Assert.Equal(mas[i], y, 3 );
            }
        }

        [Fact]
        public void Function6()
        {
            int i = 0;
            double[] mas = new double[6] { 0.697, 0.731, 0.425, 0.402, 0.57, 0.368 };
            for (double j = x1; j <= x2; j += dx )
            {
                var y = Program.Function(j, 2.5);
                Assert.Equal(mas[i], y, 3 );
                i++;
            }
        }
    }
}
