using System;

namespace HW_1_2
{
    class HW_day_2
    {
#if false
        static void Main(string[] args)
        {
            Console.Write("Введите значение A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите значение B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Введите значение C: ");
            int C = int.Parse(Console.ReadLine());

            if (C > A || C > B)
            {
                Console.WriteLine("Невозможно разместить квадраты со стороной C на прямоугольнике.");
            }
            else
            {
                int squaresCount = (A / C) * (B / C);
                int unusedArea = A * B - squaresCount * C * C;
                Console.WriteLine("Количество размещенных квадратов: " + squaresCount);
                Console.WriteLine("Площадь незанятой части прямоугольника: " + unusedArea);
            }
        } 
#endif

#if false
        static void Main(string[] args)
        {
            const double targetAmount = 11000.0;

            Console.Write("Введите значение P (в процентах): ");
            double P = double.Parse(Console.ReadLine());

            if (P <= 0 || P >= 25)
            {
                Console.WriteLine("Значение P должно быть больше 0 и меньше 25.");
                return;
            }

            double deposit = 10000.0;
            int months = 0;

            while (deposit < targetAmount)
            {
                deposit += deposit * (P / 100.0);
                months++;
            }

            Console.WriteLine("Количество месяцев: " + months);
            Console.WriteLine("Итоговый размер вклада: " + deposit);
        } 
#endif

#if false
        static void Main(string[] args)
        {
            Console.Write("Введите значение A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите значение B: ");
            int B = int.Parse(Console.ReadLine());

            if (A >= B)
            {
                Console.WriteLine("Значение A должно быть меньше B.");
                return;
            }

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        } 
#endif


#if true
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N: ");
            int N = int.Parse(Console.ReadLine());

            int reversedN = 0;

            while (N > 0)
            {
                int remainder = N % 10;
                reversedN = reversedN * 10 + remainder;
                N = N / 10;
            }

            Console.WriteLine("Число, полученное при прочтении числа N справа налево: " + reversedN);
        }
#endif
    }
}
