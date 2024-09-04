using System;

// Исключение может быть сгенерировано одним методом и перехвачено другим
// System.Exception

namespace ExceptionTwo
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("Исключение сгенерировано одним методом и перехвачено другим");

         try
         {
            ExceptionTest.GenException();
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

   internal class ExceptionTest
   {
      // Сгенерировать исключение
      public static void GenException()
      {
         int[] nums = new int[4];

         Console.WriteLine("Перед генерированием исключения");

         // Сгенерировать исключение в связи с выходом индекса за границы массива
         for (int i = 0; i < 5; i++)
         {
            nums[i] = i;
            Console.WriteLine("nums [{0}] : {1}", i, nums[i]);
         }

         Console.WriteLine("Этот текст не будет отображаться");
      }
   }
}