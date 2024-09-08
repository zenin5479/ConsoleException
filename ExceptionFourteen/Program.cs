using System;

// Инструкции перехвата исключений производных классов
// должны стоять перед инструкциями перехвата исключений базовых классов
// System.Exception

namespace ExceptionFourteen
{
   internal class Program
   {
      static void Main()
      {
         for (int x = 0; x < 3; x++)
         {
            try
            {
               if (x == 0) throw new ExceptOne("Перехват исключения типа ExceptOne");
               else if (x == 1) throw new ExceptTwo("Перехват исключения типа ExceptTwo");
               else throw new Exception();
            }
            catch (ExceptTwo exc)
            { // Перехватываем исключение
               Console.WriteLine(exc);
            }
            catch (ExceptOne exc)
            { // Перехватываем исключение
               Console.WriteLine(exc);
            }
            catch (Exception exc)
            {
               Console.WriteLine(exc);
            }
         }

         Console.ReadKey();
      }
   }

   // Создаем класс исключения
   class ExceptOne : ApplicationException
   {
      public ExceptOne() : base() { }

      public ExceptOne(string str) : base(str) { }

      public override string ToString()
      {
         return Message;
      }
   }
   // Создаем класс исключения как производный от класса ExceptOne
   class ExceptTwo : ExceptOne
   {
      public ExceptTwo() : base() { }

      public ExceptTwo(string str) : base(str) { }

      public override string ToString()
      {
         return Message;
      }
   }
}