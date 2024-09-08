using System;

// Использование ключевых слов checked и unchecked
// System.Exception

namespace ExceptionFifteen
{
   internal class Program
   {
      static void Main()
      {
         byte a, b;
         byte result;
         a = 127;
         b = 127;
         try
         {
            result = unchecked((byte)(a * b));
            Console.WriteLine("Unchecked-результат: " + result);
            // Эта инструкция вызывает исключение
            result = checked((byte)(a * b));
            // Инструкция не будет выполнена
            Console.WriteLine("Checked-реэультат: " + result);
         }
         catch (OverflowException exc)
         {
            // Перехватываем исключение
            Console.WriteLine(exc);
         }

         Console.ReadKey();
      }
   }
}