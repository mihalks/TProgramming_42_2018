using System;
using Xunit;
using CourseApp;

namespace CourseApp.tests
{
    public class UnitTest1
    {
        double x1 = 1.28; //x ���������
        double x2 = 3.28; //x ��������
        double dx = 0.4;
        double[] numbers = new double[5] { 1.1, 2.4, 3.6, 1.7, 3.9 };


        [Fact]
        public void Test1()
        {
            double y = Program.Function(1.1,2.5);
            Assert.Equal(0.739,y,3);
        }

        [Fact]
        public void Test2()
        {
            double y = Program.Function(0,2.5);
            Assert.Equal(0.403,y,3);
        }
        [Fact]
        public void Test3()
        {
            double y = Program.Function(1.1,0);
            Assert.Equal(1.767,y,3);
        }
        [Fact]
        public void Test4()
        {
            double y = Program.Function(0.0,0.0);
            Assert.Equal(double.PositiveInfinity,y,3);
        }
        [Fact]
        public void test5()
        {
            double [] mas = new double[5] {0.739,0.599,0.321,0.725,0.283};
            for (int i=0; i<mas.Length;i++)
            {
                var y = Program.Function(numbers[i],2.5);
                Assert.Equal(mas[i],y,3);
            }
        }
        [Fact]
        public void test6()
        {
            int i = 0;
            double [] mas = new double[6] {0.697,0.731,0.425,0.402,0.57,0.368};
            for (double j=x1;j<=x2;j+=dx)
            {
                var y = Program.Function(j,2.5);
                Assert.Equal(mas[i],y,3);
                i++;
            }
        }

    }
}
