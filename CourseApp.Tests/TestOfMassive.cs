using System;
using Xunit;
using CourseApp;

namespace CourseApp.tests
{
    public class UnitTest4
    {
        [Fact]
        public void Massive1()
        {
            Dog rex = new Dog();
            Cat tom = new Cat();
            var DogVoice = rex.Voice();
            var CatVoice = tom.Voice();
            Assert.Equal($"Кот Том сказал: \"Мяу!\"", CatVoice);
            Assert.Equal($"пес Rex сказал \"Гав-Гав!\"", DogVoice);
        }
    }
}