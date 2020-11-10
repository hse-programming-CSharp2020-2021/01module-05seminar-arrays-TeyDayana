using System;

/*
 * Пользователем с клавиатуры вводится целое число N > 0
 * В программе сформировать и вывести на экран целочисленный массив из N элементов
 * Значениями элементов являются степени числа 2 от нулевой до N-1 (1, 2, … 2^(N-1)).
 * Заполнение массива степенями числа 2 организовать при помощи метода.
 *
 * Пример входных данных:
 * 4
 *
 * Пример выходных данных:
 * 1 2 4 8
 */

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask02();
        }

        public static void RunTask02()
        {
            int N = int.Parse(Console.ReadLine());

            // TODO: инициализируйте массив и передайте его в соответствующий метод
            long[] array = new long[N];
            FillArray(ref array);

            // TODO: выведите массив на экран
            foreach (long elem in array)
                Console.Write(elem + "\t");
            Console.Write("\n");
        }

        static void FillArray(ref long[] array)
        {
            // TODO: заполните массив соответствующими данными
            for (int count = 0; count < array.Length; ++count)
                array[count] = (long)Math.Pow(2, count);
        }
    }
}