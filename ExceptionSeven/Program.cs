using System;

// Использование вложенного try-блока
// System.Exception

namespace ExceptionSeven
{
   internal class Program
   {
      static void Main(string[] args)
      {
         int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
         int[] denom = { 2, 0, 4, 4, 0, 8 };
         try
         {
            // Внешний try-блок.
            for (int i = 0; i < numer.Length; i++)
            {
               try
               {
                  // Вложенный try-блок.
                  Console.WriteLine(numer[i] + " / " +
                                    denom[i] + " равно " + numer[i] / denom[i]);
               }
               catch (DivideByZeroException)
               {
                  // Перехватываем исключение.
                  Console.WriteLine("На нуль делить нельзя!");
               }
            }
         }
         catch (IndexOutOfRangeException)
         {
            // Перехватываем исключение.
            Console.WriteLine("Нет соответствующего элемента.");
            Console.WriteLine(
               "Неисправимая ошибка — программа завершена.");
         }

         Console.ReadKey();
      }
   }
}
