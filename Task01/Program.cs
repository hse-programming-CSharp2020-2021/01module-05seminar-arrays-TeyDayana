using System;

/*
 * Написать метод замены всех вхождений максимального элемента массива значением, переданным в параметре.​
 *
 * В основной программе объявить и инициализировать массив
 * (данные вводятся с клавиатуры: сначала количество элементов, далее сам массив поэлементно с новой строки);
 * Из последней введенной строки получить от пользователя число,
 * заменить им все вхождения максимального элемента в массив.
 * 
 * Исходный и изменённый массивы вывести на экран.​
 *
 * Дополнительные указания смотрите непосредственно в коде
 *
 * Пример входных данных:
 * 5
 * 4
 * 7
 * 3
 * 2
 * 4
 * 10
 *
 * Пример выходных данных:
 * 4 7 3 2 4
 * 4 10 3 2 4
 */

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask01();
        }

        public static void RunTask01()
        {
            int numOfItems = int.Parse(Console.ReadLine());
            
            int[] array = new int[numOfItems];
            // TODO: считайте массив
            int max = int.MinValue;
            for (int elem = 0; elem < numOfItems; ++elem)
            {
                int.TryParse(Console.ReadLine(), out array[elem]);
                if (array[elem] > max) max = array[elem];
            }

            int newValue; // значение, которым нужно заменить все максимальные элементы
            // TODO: считайте новое значение
            int.TryParse(Console.ReadLine(), out newValue);
            
            foreach (int elem in array)
                Console.Write(elem + " ");
            Console.Write("\n");

            ReplaceMaxElem(ref array, newValue, max);

            // TODO: реализуйте вывод необходимых данных
            foreach (int elem in array)
                Console.Write(elem + " ");
            Console.Write("\n");
        }

        static void ReplaceMaxElem(ref int[] arr, int val, int max)
        {
            // TODO: реализуйте замену всех вхождений максимального элемента массива arr на значение val
            for (int elem = 0; elem < arr.Length; ++elem)
                if (arr[elem] == max)
                    arr[elem] = val;
        }
    }
}