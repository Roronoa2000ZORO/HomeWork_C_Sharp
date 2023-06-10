using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HomeWork_C_Sharp
{
    class Car
    {
        private string _driverName; //Имя водителя
        private int _currSpeed = 10; //Текущая скорость
        public Car() //Конструктор по умолчанию
        {
            _driverName = "Михаель Шумахер";
        }
        
        public void PrintState()   //Распечатка текущих данных
        {
            Console.WriteLine($"{_driverName} едет со скоростью {_currSpeed} км/ч.");
        }
    }
        class HW_day_1
    {
        static void Main(string[] args)
        {


#if false // Задание 1
            int value;
            Console.WriteLine("Введите число в диапазоне от 1 до 100.");
            value = Convert.ToInt32(Console.ReadLine());
            if (value < 1 || value > 100)
            {
                Console.WriteLine("Ошибка! Введенное число вне диапазона");
                return;
            }

            if (value % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            if (value % 5 == 0)
            {
                Console.Write("Buzz ");
            }
            else
            {
                Console.Write(value);
            } 
#endif

#if false // Задание 2
            int value, percent;

            Console.WriteLine("Введите число");
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите процент который хоитете вывести из ранее введеного числа");
            percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Процент от {0} будет составлять: {1}", value, value * (percent / 100.0)); 
#endif

#if false // Задание 3
            
            Console.WriteLine("Введите с клавиатуры 4 цыфры");
            Console.ReadLine()); 
#endif
#if false // Задание 4
            Console.WriteLine("Введите шестизначное число!");
            string value = Console.ReadLine();

            if (value.Length < 6 || value.Length > 6)
            {
                Console.WriteLine("Ошибка! Вы ввели не корректное число!");
                return;
            }

            for (int i = value.Length - 1; i >= 0; i--)
            {
                Console.Write(value[i]);
            } 
#endif


            string str = "Простая строка";
            char[] chrArr = new char[6];

            Console.WriteLine("Реверсирование строки с помощью индексатора");

            //for (int i = str.Length - 1; i >= 0; --i) Console.Write(str[i]);

            foreach (char c in str)
            {
                Console.Write(c + "\n");
            }
            Console.WriteLine("\nКопирование строки в массив символов");
            //Копируем шесть символов начиная с восьмой позиции и 
            //помещаем в массив
            //str.CopyTo(8, chrArr, 0, 6);
            //Console.WriteLine(chrArr); }
        }
    }
}
