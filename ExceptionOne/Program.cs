using System;

// Продемонстрировать обработку исключительной ситуации
// System.Exception

namespace ExceptionOne
{
   internal class Program
   {
      static void Main()
      {
         int[] nums = new int[4];
         Console.WriteLine("Сгенерировать исключение в связи с выходом индекса за границы массива int[4] nums");

         try
         {
            Console.WriteLine("Перед генерированием исключения");

            // Сгенерировать исключение в связи с выходом индекса за границы массива
            for (int i = 0; i < 5; i++)
            {
               nums[i] = i;
               Console.WriteLine("nums[(0)]: {0}", nums[i]);
            }

            Console.WriteLine("Этот текст не будет отображаться");
         }
         catch (IndexOutOfRangeException)
         {
            // Перехватить исключение
            Console.WriteLine("Индекс вне границ диапазона!");
         }

         Console.WriteLine("После catch-инструкции");
         Console.ReadKey();
      }
   }
}