using System;

// Использование нескольких catch-инструкций
// System.Exception

namespace ExceptionFive
{
   internal class Program
   {
      static void Main()
      {
         // Здесь массив numer длиннее массива denom.
         int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
         int[] denom = { 2, 0, 4, 4, 0, 8 };
         for (int i = 0; i < numer.Length; i++)
         {
            try
            {
               Console.WriteLine(numer[i] + " / " +
                                 denom[i] + " равно " + numer[i] / denom[i]);
            }
            catch (DivideByZeroException)
            {
               // Перехватываем исключение.
               Console.WriteLine("Делить на нуль нельзя!");
            }
            catch (IndexOutOfRangeException)
            {
               // Перехватываем исключение.
               Console.WriteLine("Нет соответствующего элемента.");
            }
         }
      }
   }
}