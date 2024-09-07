using System;

// Использование членов класса Exception
// System.Exception

namespace ExceptionEleven
{
   internal class Program
   {
      static void Main()
      {
         try
         {
            ExcTest.GenException();
         }
         catch (IndexOutOfRangeException exc)
         {
            // Перехватываем исключение
            Console.WriteLine("Стандартное сообщение таково: ");
            // Вызов метода ToString()
            Console.WriteLine(exc); 
            Console.WriteLine("Свойство StackTrace: " + exc.StackTrace);
            Console.WriteLine("Свойство Message: " + exc.Message);
            Console.WriteLine("Свойство TargetSite: " + exc.TargetSite);
         }

         Console.WriteLine("После catch-инструкции");
         Console.ReadKey();
      }
   }

   class ExcTest
   {
      public static void GenException()
      {
         int[] nums = new int[4];
         Console.WriteLine("Перед генерированием исключения");
         // Генерируем исключение, связанное с попаданием индекса вне диапазона
         for (int i = 0; i < 5; i++)
         {
            nums[i] = i;
            Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
         }
         Console.WriteLine("Этот текст не отображается");
      }
   }
}