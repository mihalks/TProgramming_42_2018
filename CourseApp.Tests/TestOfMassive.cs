using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestOfMassive
    {
        [Fact]
        public void Massive1()
        {
            Dog rex = new Dog();
            Cat tom = new Cat();
            var dogVoice = rex.Voice();
            var catVoice = tom.Voice();
            Assert.Equal($"Кот Том сказал: \"Мяу!\"", catVoice);
            Assert.Equal($"пес Rex сказал \"Гав-Гав!\"", dogVoice);
        }
    }
}