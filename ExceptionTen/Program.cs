using System;

// Использование блока finally
// System.Exception

namespace ExceptionTen
{
   internal class UseFinally
   {
      public static void genException(int what)
      {
         int t;
         int[] nums = new int[2];
         Console.WriteLine("Получаем " + what);
         try
         {
            switch (what)
            {
               case 0:
                  t = 10 / what; // Генерируем ошибку
                  // деления на нуль.
                  break;
               case 1:
                  nums[4] = 4; // Генерируем ошибку
                  // индексирования массива.
                  break;
               case 2:
                  return; // возврат из try-блока.
            }
         }
         catch (DivideByZeroException)
         {
            // Перехватываем исключение.
            Console.WriteLine("На нуль делить нельзя!");
            return; // Возврат из catch-блока.
         }
         catch (IndexOutOfRangeException)
         {
            // Перехватываем исключение.
            Console.WriteLine("Нет соответствующего элемента.");
         }
         finally
         {
            Console.WriteLine("По окончании try-блока.");
         }
      }


      internal class Program
      {
         static void Main(string[] args)
         {
            for (int i = 0; i < 3; i++)
            {
               genException(i);
               Console.WriteLine();
            }
         }
      }
   }
}
