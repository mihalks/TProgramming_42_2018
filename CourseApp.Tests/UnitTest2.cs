using System;
using Xunit;
using CourseApp;

namespace CourseApp.tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test7()
        {
            Cat Tom = new Cat();
            var Name = Tom.Name;
            var Age = Tom.Age;
            var Color = Tom.Color;
            Assert.Equal("Том",Name);
            Assert.Equal(5,Age);
            Assert.Equal("Серый",Color);
        }
        [Fact]
        public void Test8()
        {
            Cat Red = new Cat("Рыжик",6);
            var Name = Red.Name;
            var Age = Red.Age;
            var Color = Red.Color;
            Assert.Equal("Рыжик",Name);
            Assert.Equal(6,Age);
            Assert.Equal("рыжий",Color);
        }
        [Fact]
        public void Test9()
        {
            Cat Begemot = new Cat("Бегемот","черный");
            var Name = Begemot.Name;
            var Age = Begemot.Age;
            var Color = Begemot.Color;
            Assert.Equal("Бегемот",Name);
            Assert.Equal(7,Age);
            Assert.Equal("черный",Color);
        }
        [Fact]
        public void Test10()
        {
            Cat Tom = new Cat();  
            var Name = Tom.Name;
            Assert.Equal("Том",Name);
            string Word = Program.Meow( Tom );
            Assert.Equal($"Кот Том сказал: \"Мяу!\"",Word);          
        }
        [Fact]
        public void Test11()
        {
            Cat Tom = new Cat();
            string cat = Program.Kot( Tom );
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

        
    }
}
