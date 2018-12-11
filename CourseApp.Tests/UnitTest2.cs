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
            var s = country1.square;
            var name = country1.name;

            Assert.Equal(24140800, people);
            Assert.Equal(7692024, s);
            Assert.Equal("Australiya", name);

        }
        [Fact]
        public void test8()
        {
            Country country2 = new Country(146880432, 17125191, "Russia");
            var people = country2.people;
            var s = country2.square;
            var name = country2.name;

            Assert.Equal(146880432, people);
            Assert.Equal(17125191, s);
            Assert.Equal("Russia", name);

        }
        [Fact]
        public void test9()
        {
            Country country3 = new Country(30316, 12.6);
            var people = country3.people;
            var s = country3.square;
            var name = country3.name;

            Assert.Equal(30316, people);
            Assert.Equal(12.6, s);
            Assert.Equal("Kohma", name);

        }

        [Fact]
        public void Test10()
        {
            Country country3 = new Country();
            var name = country3.name;
            Assert.Equal("Australiya", name);
            string Word = $"Strana {name} skasala: \'Dhou!\', a mne nado pomenyat dillera";
            Assert.Equal($"Strana Australiya skasala: \'Dhou!\', a mne nado pomenyat dillera", Word);
        }
    }
}
