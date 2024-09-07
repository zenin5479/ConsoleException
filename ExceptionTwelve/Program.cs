using System;

// Использование исключения типа NullReferenceException
// System.Exception

namespace ExceptionTwelve
{
   internal class Program
   {
      static void Main()
      {
         X p = new X(10);
         // Переменной q явно присваивается значение null
         X q = null;
         int val;
         try
         {
            // Такой вызов метода приведет к исключению
            val = p.add(q);
         }
         catch (NullReferenceException)
         {
            Console.WriteLine("Исключение типа: NullReferenceException!");
            Console.WriteLine("Значение равно {0}", (q == null) ? "null" : q.ToString());
            Console.WriteLine("Исправляем ошибку...\n");
            // Исправляем ошибку
            q = new X(9);
            val = p.add(q);
            Console.WriteLine("Значение равно {0}", val);
         }


         Console.ReadKey();
      }
   }

   class X
   {
      int x;
      public X(int a)
      {
         x = a;
      }
      public int add(X o)
      {
         return x + o.x;
      }
   }
}