using System;

// Создание пользовательского исключения для обнаружения ошибок
// при работе с объектами класса RangeArray
// System.Exception

namespace ExceptionThirteen
{
   // Демонстрируем использование массива с заданным
   // диапазоном изменения индекса.
   internal class Program
   {
      static void Main()
      {
         try
         {
            RangeArray ra = new RangeArray(-5, 5);
            RangeArray ra2 = new RangeArray(1, 10);
            // Демонстрируем использование объекта-массива ra.
            Console.WriteLine("Длина массива ra: " + ra.Length);
            for (int i = -5; i <= 5; i++)
               ra[i] = i;
            Console.Write("Содержимое массива ra: ");
            for (int i = -5; i <= 5; i++)
               Console.Write(ra[i] + " ");
            Console.WriteLine("\n");
            // Демонстрируем использование объекта-массива ra2.
            Console.WriteLine("Длина массива ra2: " + ra2.Length);
            for (int i = 1; i <= 10; i++)
               ra2[i] = i;
            Console.Write("Содержимое массива ra2 : ");
            for (int i = 1; i <= 10; i++)
               Console.Write(ra2[i] + " ");
            Console.WriteLine("\n");
         }
         catch (RangeArrayException exc)
         {
            Console.WriteLine(exc);
         }
         // Теперь демонстрируем "работу над ошибками".
         Console.WriteLine(
            "Сгенерируем ошибки непопадания в диапазон.");
         // Используем неверно заданный конструктор.
         try
         {
            RangeArray ra3 = new RangeArray(100, -10); // Ошибка!
         }
         catch (RangeArrayException exc)
         {
            Console.WriteLine(exc);
         }
         // Используем неверно заданный индекс.
         try
         {
            RangeArray ra3 = new RangeArray(-2, 2);
            for (int i = -2; i <= 2; i++)
               ra3[i] = i;
            Console.Write("Содержимое массива ra3: ");
            for (int i = -2; i <= 10; i++) // Ошибка непопадания
               // в диапазон.
               Console.Write(ra3[i] + " ");
         }
         catch (RangeArrayException exc)
         {
            Console.WriteLine(exc);
         }
      }
   }

   // Создаем исключение для класса RangeArray.
   class RangeArrayException : ApplicationException
   {
      // Реализуем стандартные конструкторы.
      public RangeArrayException() : base() { }
      public RangeArrayException(string str) : base(str) { }
      // Переопределяем метод ToString() для класса
      // RangeArrayException.
      public override string ToString()
      {
         return Message;
      }
   }

   // Улучшенная версия класса RangeArray.
   class RangeArray
   {
      // Закрытые данные.
      int[] a; // Ссылка на базовый массив.
      int lowerBound; // Наименьший индекс.
      int upperBound; // Наибольший индекс.
      int len; // Базовая переменная для свойства Length.
      // Создаем массив с заданным размером.
      public RangeArray(int low, int high)
      {
         high++;
         if (high <= low)
         {
            throw new RangeArrayException(
               "Нижний индекс не меньше верхнего.");
         }
         a = new int[high - low];
         len = high - low;
         lowerBound = low;
         upperBound = --high;
      }
      // Свойство Length, предназначенное только для чтения.
      public int Length
      {
         get
         {
            return len;
         }
      }
      // Индексатор для объекта класса RangeArray.
      public int this[int index]
      {
         // Средство для чтения элемента массива.
         get
         {
            if (ok(index))
            {
               return a[index - lowerBound];
            }
            else
            {
               throw new RangeArrayException(
                  "Ошибка нарушения границ диапазона.");
            }
         }
         // Средство для записи элемента массива.
         set
         {
            if (ok(index))
            {
               a[index - lowerBound] = value;
            }
            else throw new RangeArrayException(
               "Ошибка нарушения границ диапазона.");
         }
      }
      // Метод возвращает значение true,
      // если индекс в пределах диапазона.
      private bool ok(int index)
      {
         if (index >= lowerBound & index <= upperBound)
            return true;
         return false;
      }
   }
}
