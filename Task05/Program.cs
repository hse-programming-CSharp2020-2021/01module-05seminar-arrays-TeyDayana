using System;

/*
 * Пользователем с клавиатуры вводится целое число N > 1.
 * В программе сформировать целочисленный массив,
 * содержащий N первых элементов последовательности Фибоначчи:
 * A[0] = 1, A[1] = 1, A[2] = A[0] + A[1], … A[K] = A[K-1] + A[K-2], …
 * 
 * Формирование массива организовать при помощи метода.
 * Элементы массива вывести на экран в обратном порядке.
 * Методы класса Array НЕ использовать.
 *
 * Пример входных данных:
 * 5
 *
 * Пример выходных данных:
 * 5 3 2 1 1
 */

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask05();
        }

        public static void RunTask05()
        {
            int N = int.Parse(Console.ReadLine());

            // TODO: объявите массив и вызовите метод для его заполнения
            int[] array = new int[N];
            Result(ref array);

            // TODO: выведите массив на экран в требуемом порядке
            for (int count = N - 1; count >= 0; --count)
                Console.Write(array[count] + " ");
            Console.Write("\n");
        }

        public static void Result(ref int[] array)
        {
            array[0] = 1;
            array[1] = 1;
            for (int elem = 2; elem < array.Length; ++elem)
                array[elem] = array[elem - 1] + array[elem - 2];
        }
    }
}