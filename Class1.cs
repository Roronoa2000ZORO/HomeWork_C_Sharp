using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_C_Sharp
{
    class Class1
    {
#if false //Задание 1
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 4, 6, 8, 10 };
            Console.WriteLine("Массив: " + string.Join(", ", array));

            int evenCount = CountEvenElements(array);
            Console.WriteLine("Количество чётных элементов: " + evenCount);

            int oddCount = CountOddElements(array);
            Console.WriteLine("Количество нечётных элементов: " + oddCount);

            int uniqueCount = CountUniqueElements(array);
            Console.WriteLine("Количество уникальных элементов: " + uniqueCount);
        }

        static int CountEvenElements(int[] array)
        {
            int count = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        static int CountOddElements(int[] array)
        {
            int count = 0;

            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        static int CountUniqueElements(int[] array)
        {
            HashSet<int> uniqueSet = new HashSet<int>(array);
            return uniqueSet.Count;
        } 
#endif

#if false //Задание 2
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 9, 3, 1, 7, 4, 6, 8, 10 };
            Console.WriteLine("Массив: " + string.Join(", ", array));

            Console.Write("Введите значение: ");
            int target = Convert.ToInt32(Console.ReadLine());

            int count = CountValuesLessThanTarget(array, target);
            Console.WriteLine("Количество значений меньше {0}: {1}", target, count);
        }

        static int CountValuesLessThanTarget(int[] array, int target)
        {
            int count = 0;

            foreach (int num in array)
            {
                if (num < target)
                {
                    count++;
                }
            }

            return count;
        }
#endif

#if false //Задание 3
        static void Main(string[] args)
        {
            int[] array = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            Console.WriteLine("Массив: " + string.Join(", ", array));

            Console.WriteLine("Введите три числа через пробел:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int[] sequence = new int[3];
            for (int i = 0; i < 3; i++)
            {
                sequence[i] = Convert.ToInt32(numbers[i]);
            }

            int count = CountSequenceOccurrences(array, sequence);
            Console.WriteLine("Количество повторений последовательности: " + count);
        }

        static int CountSequenceOccurrences(int[] array, int[] sequence)
        {
            int count = 0;
            int sequenceLength = sequence.Length;

            for (int i = 0; i <= array.Length - sequenceLength; i++)
            {
                bool isMatch = true;

                for (int j = 0; j < sequenceLength; j++)
                {
                    if (array[i + j] != sequence[j])
                    {
                        isMatch = false;
                        break;
                    }
                }

                if (isMatch)
                {
                    count++;
                }
            }

            return count;
        }
#endif

#if false //Задание 4
        static void Main(string[] args)
        {
            int[] array1 = { 2, 4, 6, 8, 10 };
            int[] array2 = { 1, 3, 5, 4, 7 };
            Console.WriteLine("Массив 1: " + string.Join(", ", array1));
            Console.WriteLine("Массив 2: " + string.Join(", ", array2));

            int[] commonElements = GetCommonElements(array1, array2);
            Console.WriteLine("Общие элементы без повторений: " + string.Join(", ", commonElements));
        }

        static int[] GetCommonElements(int[] array1, int[] array2)
        {
            int[] commonElements = array1.Intersect(array2).Distinct().ToArray();
            return commonElements;
        }
#endif

#if false //Задание 5
        static void Main(string[] args)
        {
            int[,] array = {
                { 3, 5, 2 },
                { 9, 1, 7 },
                { 4, 8, 6 }
            };

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            int min = array[0, 0];
            int max = array[0, 0];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int currentElement = array[row, col];

                    if (currentElement < min)
                    {
                        min = currentElement;
                    }

                    if (currentElement > max)
                    {
                        max = currentElement;
                    }
                }
            }

            Console.WriteLine("Массив:");
            PrintArray(array);

            Console.WriteLine("Минимальное значение: " + min);
            Console.WriteLine("Максимальное значение: " + max);
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(array[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
#endif

    }
}
