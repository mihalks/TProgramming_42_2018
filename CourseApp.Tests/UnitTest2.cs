using System;
using Xunit; 
using ConsoleApp1;


namespace CourseApp.Tests
{
    public class UnitTest2
    {

        
        [Fact]
        public void test7()
        {
            Country country1 = new Country();
            var people = country1.people;
            var Square = country1.Square;
            var Name = country1.Name;

            Assert.Equal(24140800, people);
            Assert.Equal(7692024, Square);
            Assert.Equal("Australiya", Name);

        }

        [Fact]
        public void test8()
        {
            Country country2 = new Country(30316, 12.6);
            var people = country2.people;
            var Square = country2.Square;
            var Name = country2.Name;

            Assert.Equal(30316, people);
            Assert.Equal(12.6, Square);
            Assert.Equal("Kohma", Name);

        }

        [Fact]
        public void Test9()
        {
            Country country2 = new Country();
            var Name = country2.Name;
            Assert.Equal("Australiya", Name);
            string Word = $"Strana {Name} skasala: \'Dhou!\', a mne nado pomenyat dillera";
            Assert.Equal($"Strana Australiya skasala: \'Dhou!\', a mne nado pomenyat dillera", Word);
        }
    }
}
