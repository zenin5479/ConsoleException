using System;

// Возможность красиво выходить из ошибочных ситуаций
// System.Exception

namespace ExceptionFour
{
   internal class Program
   {
      static void Main()
      {
         int[] divisible = { 4, 8, 16, 32, 64, 128 };
         int[] denom = { 2, 0, 4, 4, 0, 8 };
         for (int i = 0; i < divisible.Length; i++)
         {
            try
            {
               Console.WriteLine(divisible[i] + " / " + denom[i] + " равно " + divisible[i] / denom[i]);
            }
            catch (DivideByZeroException)
            {
               // Перехватываем исключение
               Console.WriteLine("Делить на нуль нельзя!");
            }
         }
      }
   }
}