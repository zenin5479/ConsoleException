using System;

// Использование нескольких catch-инструкций
// System.Exception

namespace ExceptionFive
{
   internal class Program
   {
      static void Main()
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
            }
         }

         Console.ReadKey();
      }
   }
}