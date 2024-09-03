using System;

// System.Exception

namespace ExceptionOne
{
   internal class Program
   {
      static void Main()
      {
         int[] nums = new int[4];

         try
         {
            Console.WriteLine("Сгенерировать исключение в связи с выходом индекса за границы массива int[4] nums");
            Console.WriteLine("До генерирования исключения.");

            // Сгенерировать исключение в связи с выходом индекса за границы массива
            for (int i = 0; i < 5; i++)
            {
               nums[i] = i;
               Console.WriteLine("nums[(0)]: {0}", nums[i]);
            }
            Console.WriteLine("He подлежит выводу");
         }
         catch (IndexOutOfRangeException)
         {
            // Перехватить исключение.
            Console.WriteLine("Индекс вышел за границы массива!");
         }
         Console.WriteLine("После блока перехвата исключения.");

         Console.ReadKey();
      }
   }
}
