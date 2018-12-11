using System;

namespace CourseApp
{
    public class Cat
    {
        private float age;

        public Cat()
            : this("Том", 5)
        {
            Color = "Серый";
        }

        public Cat(string name, float age)
        {
            Name = name;
            Age = age;
            Color = "рыжий";
        }

        public Cat(string name, string color)
            : this(name, 7)
        {
            Color = color;
        }

        public string Name { get; set; }

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

        public string Color { get; set; }

        public void Display()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age} лет, окрас: {Color} ");
        }

        public string Meow()
        {
            return $"Кот {Name} сказал: \"Мяу!\"";
        }

        public string Kotik()
        {
            return @"
	
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
";
        }
    }
}
