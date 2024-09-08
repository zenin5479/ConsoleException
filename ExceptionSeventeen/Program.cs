using System;
using System.Threading.Tasks;

// Исключения в асинхронных и итераторах
// System.Exception

namespace ExceptionSeventeen
{
   internal class Program
   {
      static async Task Main()
      {
         await Run();

         Console.ReadKey();
      }

      public static async Task Run()
      {
         try
         {
            Task<int> processing = ProcessAsync(-1);
            Console.WriteLine("Запущена обработка");
            int result = await processing;
            Console.WriteLine($"Результат: {result}.");
         }
         catch (ArgumentException e)
         {
            Console.WriteLine($"Ошибка обработки: {e.Message}");
         }
      }

      private static async Task<int> ProcessAsync(int input)
      {
         if (input < 0)
         {
            throw new ArgumentOutOfRangeException(nameof(input), "Входные данные должны быть неотрицательными");
         }

         await Task.Delay(500);
         return input;
      }
   }
}