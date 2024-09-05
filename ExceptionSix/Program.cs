using System;

// Использование catch-инструкции для "глобального перехвата"
// System.Exception

namespace ExceptionSix
{
   internal class Program
   {
      static void Main()
      {
         // Здесь массив numer длиннее массива denom.
         int[] divisible = { 4, 8, 16, 32, 64, 128, 256, 512, 1024 };
         int[] divider = { 2, 0, 4, 8, 0, 16, 32 };
         for (int i = 0; i < divisible.Length; i++)
         {
            try
            {
               Console.WriteLine(divisible[i] + " / " + divider[i] + " равно " + divisible[i] / divider[i]);
            }
            catch
            {
               Console.WriteLine(
                  "Произошло некоторое исключение");
            }
         }
      }
   }
}
