using System;
using Xunit;
using CourseApp;

namespace CourseApp.tests
{
    public class UnitTest2
    {
        [Fact]
        public void Cat1()
        {
            Cat tom = new Cat();
            var Name = tom.Name;
            var Age = tom.Age;
            var Color = tom.Color;
            Assert.Equal("Том",Name);
            Assert.Equal(5,Age);
            Assert.Equal("Серый",Color);
        }
        [Fact]
        public void Cat2()
        {
            Cat red = new Cat("Рыжик",6);
            var Name = red.Name;
            var Age = red.Age;
            var Color = red.Color;
            Assert.Equal("Рыжик",Name);
            Assert.Equal(6,Age);
            Assert.Equal("рыжий",Color);
        }
        [Fact]
        public void Cat3()
        {
            Cat begemot = new Cat("Бегемот","черный");
            var Name = begemot.Name;
            var Age = begemot.Age;
            var Color = begemot.Color;
            Assert.Equal("Бегемот",Name);
            Assert.Equal(7,Age);
            Assert.Equal("черный",Color);
        }
        [Fact]
        public void Cat4()
        {
            Cat tom = new Cat();  
            var Name = tom.Name;
            Assert.Equal("Том",Name);
            string Word = Program.Meow( tom );
            Assert.Equal($"Кот Том сказал: \"Мяу!\"",Word);          
        }
        [Fact]
        public void Cat5()
        {
            Cat tom = new Cat();
            string cat = Program.Kot( tom );
            Assert.Equal(@"
	
          ,.                 .,
         ,: ':.    .,.    .:' :,
         ,',   '.:'   ':.'   ,',
         : '.  '         '  .' :
         ', : '           ' : ,'
         '.' .,:,.   .,:,. '.'
          ,:    V '. .' V    :,
         ,:        / '        :,
         ,:                   :,
          ,:       =:=       :,
           ,: ,     :     , :,
            :' ',.,' ',.,:' ':
           :'      ':WW::'   '.
          .:'       '::::'   ':
          ,:        '::::'    :,
          :'         ':::'    ':
         ,:           ':''     :.
        .:'             '.     ',.
       ,:'               ''     '.
       .:'               .',    ':
      .:'               .'.,     :
      .:                .,''     :
      ::                .,''    ,:
      ::              .,'','   .:'
    .,::'.           .,','     ::::.
  .:'     ',.       ,:,       ,WWWWW,
  :'        :       :W:'     :WWWWWWW,          .,.
  :         ',      WWW      WWWWWWWWW          '::,
  '.         ',     WWW     :WWWWWWWWW            '::,
   '.         :     WWW     :WWWWWWWW'             :::
    '.       ,:     WWW     :WWWWWWW'             .:::
     '.     .W:     WWW     :WWWWWW'           .,:::'
      '.   :WW:     WWW     :WWWWW'      .,,:::::''
     .,'   ''::     :W:     :WWWWW.  .,::::''
  ,'        ''','',',','','''WWWWW::::''
   ':,,,,,,,':  :  : : :  :  :WWWW'''
",cat);    
        }            

        [Fact]
        public void Cat6()
        {
            Cat tom = new Cat();
            string ToStr = tom.ToString();
            Assert.Equal($"Кот Том замурлыкал",ToStr);
        }
    }
}
