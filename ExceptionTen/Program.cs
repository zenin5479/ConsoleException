using System;

// Использование блока finally
// System.Exception

namespace ExceptionTen
{
   internal class Program
   {
      static void Main()
      {
         for (int i = 0; i < 3; i++)
         {
            UseFinally.GenException(i);
            Console.WriteLine();
         }

         Console.ReadKey();
      }
   }

   internal class UseFinally
   {
      public static void GenException(int what)
      {
         int t;
         int[] nums = new int[2];
         Console.WriteLine("Получаем " + what);
         try
         {
            switch (what)
            {
               // Генерируем ошибку деления на нуль
               case 0:
                  t = 10 / what;
                  break;
               // Генерируем ошибку индексирования массива
               case 1:
                  nums[4] = 4;
                  break;
               // Возврат из try-блока
               case 2:
                  return;
            }
         }
         catch (DivideByZeroException)
         {
            // Перехватываем исключение
            Console.WriteLine("На нуль делить нельзя!");
         }
         catch (IndexOutOfRangeException)
         {
            // Перехватываем исключение
            Console.WriteLine("Нет соответствующего элемента");
         }
         finally
         {
            // Независимо от итога завершения try-блока, блок finally выполняется обязательно
            Console.WriteLine("Использование блока finally");
            Console.WriteLine("По окончании try-блока");
         }
      }
   }
}