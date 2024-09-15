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
         Console.WriteLine(MakeRequest().Result);
         Console.ReadKey();
      }

      private static async Task<string> MakeRequest()
      {
         HttpClient client = new HttpClient();
         Task<string> streamTask = client.GetStringAsync("https://metanit.com");
         try
         {
            string responseText = await streamTask;
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