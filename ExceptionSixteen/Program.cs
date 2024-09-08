using System;

// Использование ключевых слов checked и unchecked для блоков инструкций
// System.Exception

namespace ExceptionSixteen
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
            unchecked
            {
               a = 127;
               b = 127;
               result = unchecked((byte)(a * b));
               Console.WriteLine("Unchecked-результат: " + result);
               a = 125;
               b = 5;
               result = unchecked((byte)(a * b));
               Console.WriteLine("Unchecked-реэультат: " + result);
            }
            checked
            {
               a = 2;
               b = 7;
               // Все в порядке
               result = checked((byte)(a * b));
               Console.WriteLine("Checked-результат: " + result);
               a = 127;
               b = 127;
               // Здесь должно быть сгенерировано исключение
               // Эта инструкция не выполнится
               result = checked((byte)(a * b));
               Console.WriteLine("Checked-результат: " + result);
            }
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