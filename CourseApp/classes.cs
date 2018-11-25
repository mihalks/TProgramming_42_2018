using System;

namespace CourseApp
{
    public class Cat
    {
        private float age;
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

        public Cat() { Name = "Том"; Age = 5; Color = "Серый"; } //1-й конструктор
        public Cat(string n, float a) {Name = n; Age = a; Color = "рыжий"; } //2-й конструктор
        public Cat(string n, string c) { Name = n; Age = 7; Color = c; }   //3-й конструктор

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age} лет, окрас: {Color} ");
        }

        public string Meow() 
        {
            return $"кот {Name} сказал: \"Мяу!\"";
        }
        
        public void Kotik()
        {
            Console.WriteLine(@"
	
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
");

        }
    }
}


