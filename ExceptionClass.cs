using System;
namespace Exception
{
    public class ExceptionClass
    {
        private int age;
        public string Name { get; set; }
        public int Age
        {
            get => age;
            set
            {
                if (value < 18)
                {
                    throw new System.Exception("Людям не достигшим 18 летнего возраста регистрация запрещена");

                }
                else
                {
                    age = value;
                }
            }
        }
        public void Display()
        {
            Console.WriteLine($"Имя пользователя : {Name} , Возраст пользователя : {age}");
        }
    }
}
