using System;

// Инструкции перехвата исключений производных классов
// должны стоять перед инструкциями перехвата исключений базовых классов
// System.Exception

namespace ExceptionFourteen
{
   internal class Program
   {
      static void Main(string[] args)
      {
         for (int x = 0; x < 3; x++)
         {
            try
            {
               if (x == 0) throw new ExceptA(
                  "Перехват исключения типа ExceptA.");
               else if (x == 1) throw new ExceptB(
                  "Перехват исключения типа ExceptB.");
               else throw new Exception();
            }
            catch (ExceptB exc)
            { // Перехватываем исключение.
               Console.WriteLine(exc);
            }
            catch (ExceptA exc)
            { // Перехватываем исключение.
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

   // Создаем класс исключения.
   class ExceptA : ApplicationException
   {
      public ExceptA() : base() { }
      public ExceptA(string str) : base(str) { }
      public override string ToString()
      {
         return Message;
      }
   }
   // Создаем класс исключения как производный
   //от класса ExceptA.
   class ExceptB : ExceptA
   {
      public ExceptB() : base() { }
      public ExceptB(string str) : base(str) { }
      public override string ToString()
      {
         return Message;
      }
   }
}
