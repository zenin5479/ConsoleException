using System;

// Повторное генерирование исключения
// System.Exception

namespace ExceptionNine
{
   internal class Program
   {
      static void Main()
      {
         try
         {
            Rethrow.GenException();
         }
         catch (IndexOutOfRangeException)
         {
            // Перехватываем повторно сгенерированное исключение
            Console.WriteLine("Неисправимая ошибка — " + "программа завершена");
         }

         Console.ReadKey();
      }

      class Rethrow
      {
         public static void GenException()
         {
            // Здесь массив divisible длиннее массива divider
            int[] divisible = { 4, 8, 16, 32, 64, 128, 256, 512, 1024 };
            int[] divider = { 2, 0, 4, 8, 0, 16, 32 };
            for (int i = 0; i < divisible.Length; i++)
            {
               try
               {
                  Console.WriteLine(divisible[i] + "/" + divider[i] + " равно " + divisible[i] / divider[i]);
               }
               catch (DivideByZeroException)
               {
                  // Перехватываем исключение
                  Console.WriteLine("Делить на нуль нельзя!");
               }
               catch (IndexOutOfRangeException)
               {
                  // Перехватываем исключение
                  Console.WriteLine("Нет соответствующего элемента");
                  // Генерируем исключение повторно
                  throw; 
               }
            }
         }
      }
   }
}