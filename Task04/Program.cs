using System;

/*
 * Пользователем с клавиатуры вводятся целые числа N > 1, A и D.
 * В программе сформировать и вывести на экран целочисленный массив из N элементов.
 * Элементы вычисляются: A[0] = A, A[1] = A + D, A[2] = A + 2*D, … A[N-1] = A + (N-1)*D.
 * Формирование массива организовать при помощи метода.​
 *
 * Пример входных данных:
 * 5
 * 3
 * 4
 *
 * Пример выходных данных:
 * 3 7 11 15 19
 */

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask04();
        }

        public static void RunTask04()
        {
            int N = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            // TODO: инициализируйте массив и передайте его в соответствующий метод
            long[] array = new long[N];
            for (int count = 0; count < N; ++count)
                array[count] = a + count * d;

            // TODO: выведите массив на экран
            foreach (long elem in array)
                Console.Write(elem + " ");
            Console.Write("\n");
        }
    }
}