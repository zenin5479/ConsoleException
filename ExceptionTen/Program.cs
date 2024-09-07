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
               // Деления на нуль
               case 0:
                  break;
               case 1:
                  // Генерируем ошибку
                  nums[4] = 4; 
                  // Индексирования массива
                  break;
               case 2:
                  // Возврат из try-блока
                  return; 
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