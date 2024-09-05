using System;

// Возможность красиво выходить из ошибочных ситуаций
// System.Exception

namespace ExceptionFour
{
   internal class Program
   {
      static void Main()
      {
         int[] divisible = { 4, 8, 16, 32, 64, 128, 256 };
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
         }

         Console.ReadKey();
      }
   }
}