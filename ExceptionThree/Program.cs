using System;

// Предоставить исполняющей системе возможность самой обрабатывать ошибки
// System.Exception

namespace ExceptionThree
{
   internal class Program
   {
      static void Main()
      {
         int[] nums = new int[4];
         Console.WriteLine("До генерирования исключения");
         // Сгенерировать исключение в связи с выходом индекса за границы массива
         for (int i = 0; i < 10; i++)
         {
            nums[i] = i;
            Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
         }
      }
   }
}