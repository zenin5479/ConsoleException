using System;

// Фильтр исключений when
// System.Exception

namespace ExceptionEighteen
{
   internal class Program
   {
      static void Main()
      {
         int x = 1;
         int y = 0;

         try
         {
            int result1 = x / y;
            int result2 = y / x;
         }
         catch (DivideByZeroException) when (y == 0)
         {
            Console.WriteLine("y не должен быть равен 0");
         }
         catch (DivideByZeroException ex)
         {
            Console.WriteLine(ex.Message);
         }

         Console.ReadKey();
      }
   }
}