using System;

// Использование блока finally
// System.Exception

namespace ExceptionTen
{
   internal class UseFinally
   {
      public static void GenException(int what)
      {
         int[] nums = new int[2];
         Console.WriteLine("Получаем " + what);
         try
         {
            switch (what)
            {
               case 0:
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
         static void Main()
         {
            for (int i = 0; i < 3; i++)
            {
               GenException(i);
               Console.WriteLine();
            }
         }
      }
   }
}