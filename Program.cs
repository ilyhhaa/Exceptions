using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////
            ///////////////FormatExeption//////////////
            ///////////////////////////////////////////

            try
            {
                Console.WriteLine("Введите первое слогаемое");/////////Намеренно вводим строку или символ
                int Input = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе слогаемое"); /////////Намеренно вводим строку или символ
                int Input1 = int.Parse(Console.ReadLine());

                int Add = Input + Input1;
                Console.WriteLine(Add);


            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }

            ///////////////////////////////////////////
            ///////////////Throw///////////////////////
            ///////////////////////////////////////////
            Console.WriteLine("Введите имя пользователя");
            string? name = Console.ReadLine();
            try
            {
                if (name == null || name.Length <= 3)
                {
                    throw new System.Exception ("Длина имени должна быть больше трех");
                }
                else
                {
                    Console.WriteLine(name);
                }
                
               
            }
            catch (SystemException e)
            {
                Console.WriteLine("Ошибка : " + e.Message);
                throw;
            }

            ///////////////////////////////////////////
            ///////////////ClassesException////////////
            ///////////////////////////////////////////
            ExceptionClass exception = new ExceptionClass(){ Age = 12, Name = "Ilya" };
            exception.Display();
        }






    }
}
