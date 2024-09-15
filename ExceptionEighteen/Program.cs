using System;
using System.Net.Http;
using System.Threading.Tasks;

// Фильтр исключений when
// System.Exception

namespace ExceptionEighteen
{
   internal class Program
   {
      static void Main()
      {
         HandlingExceptions();
         Console.WriteLine(MakeRequest().Result);
         Console.ReadKey();
      }

      public static void HandlingExceptions()
      {
         int x = 1;
         int y = 0;

         try
         {
            int result1 = x / y;
            int result2 = y / x;
         }
         catch (DivideByZeroException) when (y == 0)
         {
            Console.WriteLine("y не должен быть равен 0");
         }
         catch (DivideByZeroException ex)
         {
            Console.WriteLine(ex.Message);
         }
      }

      public static async Task<string> MakeRequest()
      {
         var client = new HttpClient();
         var streamTask = client.GetStringAsync("https://metanit.com");
         try
         {
            var responseText = await streamTask;
            return responseText;
         }
         catch (HttpRequestException e) when (e.Message.Contains("301"))
         {
            return "Сайт перемещен";
         }
         catch (HttpRequestException e) when (e.Message.Contains("403"))
         {
            return "Код состояния ответа не указывает на успешное выполнение";
         }
         catch (HttpRequestException e) when (e.Message.Contains("404"))
         {
            return "Страница не найдена";
         }
         catch (HttpRequestException e)
         {
            return e.Message;
         }
      }
   }
}