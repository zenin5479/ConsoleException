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
         try
         {
            // Такой вызов метода приведет к исключению
            p.Add(q);
         }
         catch (NullReferenceException)
         {
            Console.WriteLine("Исключение типа: NullReferenceException!");
            Console.WriteLine("Значение равно {0}", (q == null) ? "null" : q.ToString());
            Console.WriteLine("Исправляем ошибку...");
            // Исправляем ошибку
            q = new X(9);
            int val = p.Add(q);
            Console.WriteLine("Значение равно {0}", val);
         }

         Console.ReadKey();
      }
   }

   class X
   {
      private readonly int _x;
      public X(int a)
      {
         _x = a;
      }
      public int Add(X o)
      {
         return _x + o._x;
      }
   }
}