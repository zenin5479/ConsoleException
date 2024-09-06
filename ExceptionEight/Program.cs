using System;

// Генерирование исключения вручную
// System.Exception

namespace ExceptionEight
{
   internal class Program
   {
      static void Main()
      {
         try
         {
            Console.WriteLine("До генерирования исключения");
            throw new DivideByZeroException();
         }
         catch (DivideByZeroException)
         {
            // Перехватываем исключение
            Console.WriteLine("Исключение перехвачено");
         }
         Console.WriteLine("После try/catch-блока");

         Console.ReadKey();
      }
   }
}