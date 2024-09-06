using System;

// Использование вложенного try-блока
// System.Exception

namespace ExceptionSeven
{
   internal class Program
   {
      static void Main(string[] args)
      {
         int[] divisible = { 4, 8, 16, 32, 64, 128, 256, 512, 1024 };
         int[] divider = { 2, 0, 4, 8, 0, 16, 32 };
         try
         {
            // Внешний try-блок
            for (int i = 0; i < divisible.Length; i++)
            {
               try
               {
                  // Вложенный try-блок
                  Console.WriteLine(divisible[i] + "/" + divider[i] + " равно " + divisible[i] / divider[i]);
               }
               catch (DivideByZeroException)
               {
                  // Перехватываем исключение
                  Console.WriteLine("На нуль делить нельзя!");
               }
            }
         }
         catch (IndexOutOfRangeException)
         {
            // Перехватываем исключение
            Console.WriteLine("Нет соответствующего элемента");
            Console.WriteLine("Неисправимая ошибка — программа завершена");
         }

         Console.ReadKey();
      }
   }
}