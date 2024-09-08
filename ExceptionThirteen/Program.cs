using System;

// Создание пользовательского исключения для обнаружения ошибок
// при работе с объектами класса RangeArray
// System.Exception

namespace ExceptionThirteen
{
   internal class Program
   {
      static void Main()
      {
         // Демонстрируем использование массива с заданным диапазоном изменения индекса
         try
         {
            RangeArray rangeArray = new RangeArray(-5, 5);
            RangeArray rangeArray2 = new RangeArray(1, 10);
            // Демонстрируем использование объекта-массива ra
            Console.WriteLine("Длина массива ra: " + rangeArray.Length);
            for (int i = -5; i <= 5; i++)
               rangeArray[i] = i;
            Console.Write("Содержимое массива ra: ");
            for (int i = -5; i <= 5; i++)
               Console.Write(rangeArray[i] + " ");
            Console.WriteLine("\n");
            // Демонстрируем использование объекта-массива ra2
            Console.WriteLine("Длина массива ra2: " + rangeArray2.Length);
            for (int i = 1; i <= 10; i++)
               rangeArray2[i] = i;
            Console.Write("Содержимое массива ra2 : ");
            for (int i = 1; i <= 10; i++)
               Console.Write(rangeArray2[i] + " ");
            Console.WriteLine("\n");
         }
         catch (RangeArrayException exc)
         {
            Console.WriteLine(exc);
         }
         // Теперь демонстрируем "работу над ошибками"
         Console.WriteLine("Сгенерируем ошибки непопадания в диапазон");
         // Используем неверно заданный конструктор
         try
         {
            // Ошибка!
            RangeArray ra3 = new RangeArray(100, -10);
         }
         catch (RangeArrayException exc)
         {
            Console.WriteLine(exc);
         }

         // Используем неверно заданный индекс
         try
         {
            RangeArray rangeArray3 = new RangeArray(-2, 2);
            for (int i = -2; i <= 2; i++)
               rangeArray3[i] = i;
            Console.Write("Содержимое массива ra3: ");
            // Ошибка непопадания в диапазон
            for (int i = -2; i <= 10; i++)
               Console.Write(rangeArray3[i] + " ");
         }
         catch (RangeArrayException exc)
         {
            Console.WriteLine(exc);
         }
      }
   }

   // Создаем исключение для класса RangeArray
   class RangeArrayException : ApplicationException
   {
      // Реализуем стандартные конструкторы
      public RangeArrayException() : base() { }

      public RangeArrayException(string str) : base(str) { }

      // Переопределяем метод ToString() для класса RangeArrayException
      public override string ToString()
      {
         return Message;
      }
   }

   // Улучшенная версия класса RangeArray
   class RangeArray
   {
      // Закрытые данные
      // Ссылка на базовый массив
      private readonly int[] _a;
      // Наименьший индекс
      private readonly int _lowerBound;
      // Наибольший индекс
      private readonly int _upperBound;
      // Базовая переменная для свойства Length
      private readonly int _len;
      // Создаем массив с заданным размером
      public RangeArray(int low, int high)
      {
         high++;
         if (high <= low)
         {
            throw new RangeArrayException(
               "Нижний индекс не меньше верхнего");
         }
         _a = new int[high - low];
         _len = high - low;
         _lowerBound = low;
         _upperBound = --high;
      }
      // Свойство Length, предназначенное только для чтения
      public int Length
      {
         get
         {
            return _len;
         }
      }
      // Индексатор для объекта класса RangeArray
      public int this[int index]
      {
         // Средство для чтения элемента массива
         get
         {
            if (Ok(index))
            {
               return _a[index - _lowerBound];
            }
            else
            {
               throw new RangeArrayException("Ошибка нарушения границ диапазона");
            }
         }
         // Средство для записи элемента массива
         set
         {
            if (Ok(index))
            {
               _a[index - _lowerBound] = value;
            }
            else throw new RangeArrayException("Ошибка нарушения границ диапазона");
         }
      }
      // Метод возвращает значение true, если индекс в пределах диапазона
      private bool Ok(int index)
      {
         if (index >= _lowerBound & index <= _upperBound)
            return true;
         return false;
      }
   }
}