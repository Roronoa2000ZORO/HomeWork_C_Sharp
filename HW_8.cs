using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_C_Sharp
{
    class HW_8
    {

#if false // Задание 1
        static void Main()
        {
            Console.WriteLine("Введите начало диапазона:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конец диапазона:");
            int end = int.Parse(Console.ReadLine());

            try
            {
                long product = CalculateProductInRange(start, end);
                Console.WriteLine($"Произведение чисел в диапазоне [{start}, {end}]: {product}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static long CalculateProductInRange(int start, int end)
        {
            if (end < start)
            {
                throw new ArgumentException("Конец диапазона должен быть больше или равен началу.");
            }

            long product = 1;

            for (int i = start; i <= end; i++)
            {
                product *= i;
            }

            return product;
        } 
#endif

#if false // Задание 2
        static void Main()
        {
            Console.WriteLine("Введите число для проверки:");
            int number = int.Parse(Console.ReadLine());

            bool isFibonacci = IsFibonacciNumber(number);

            Console.WriteLine($"Число {number} является числом Фибоначчи: {isFibonacci}");
        }

        static bool IsFibonacciNumber(int number)
        {
            // Числа Фибоначчи: 0, 1, 1, 2, 3, 5, 8, 13, 21, ...
            // Если число находится в последовательности чисел Фибоначчи,
            // то оно может быть представлено в виде sum = a + b, где a и b - предыдущие числа Фибоначчи.

            int a = 0;
            int b = 1;
            int sum = a + b;

            while (sum < number)
            {
                a = b;
                b = sum;
                sum = a + b;
            }

            return sum == number;
        } 
#endif

#if false // Задание 3
        static void Main()
        {
            Console.WriteLine("Введите элементы массива через пробел:");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine("Выберите порядок сортировки (1 - по возрастанию, 2 - по убыванию):");
            int sortOrder = int.Parse(Console.ReadLine());

            if (sortOrder == 1)
            {
                BubbleSortAscending(array);
                Console.WriteLine("Массив отсортирован по возрастанию:");
            }
            else if (sortOrder == 2)
            {
                BubbleSortDescending(array);
                Console.WriteLine("Массив отсортирован по убыванию:");
            }
            else
            {
                Console.WriteLine("Некорректный выбор порядка сортировки.");
                return;
            }

            Console.WriteLine(string.Join(" ", array));
        }

        static void BubbleSortAscending(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void BubbleSortDescending(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        } 
#endif

    }


#if false // Задание 4
    class City
    {
        private string cityName;
        private string countryName;
        private int population;
        private string phoneCode;
        private string[] districts;

        public void SetCityName(string name)
        {
            cityName = name;
        }

        public string GetCityName()
        {
            return cityName;
        }

        public void SetCountryName(string name)
        {
            countryName = name;
        }

        public string GetCountryName()
        {
            return countryName;
        }

        public void SetPopulation(int count)
        {
            population = count;
        }

        public int GetPopulation()
        {
            return population;
        }

        public void SetPhoneCode(string code)
        {
            phoneCode = code;
        }

        public string GetPhoneCode()
        {
            return phoneCode;
        }

        public void SetDistricts(string[] districtNames)
        {
            districts = districtNames;
        }

        public string[] GetDistricts()
        {
            return districts;
        }

        public void InputData()
        {
            Console.WriteLine("Введите название города:");
            cityName = Console.ReadLine();

            Console.WriteLine("Введите название страны:");
            countryName = Console.ReadLine();

            Console.WriteLine("Введите количество жителей в городе:");
            population = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите телефонный код города:");
            phoneCode = Console.ReadLine();

            Console.WriteLine("Введите название районов города через пробел:");
            string districtsString = Console.ReadLine();
            districts = districtsString.Split(' ');
        }

        public void OutputData()
        {
            Console.WriteLine("Название города: " + cityName);
            Console.WriteLine("Название страны: " + countryName);
            Console.WriteLine("Количество жителей: " + population);
            Console.WriteLine("Телефонный код: " + phoneCode);
            Console.WriteLine("Название районов:");
            foreach (string district in districts)
            {
                Console.WriteLine("- " + district);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            City city = new City();
            city.InputData();
            Console.WriteLine();
            city.OutputData();
        }
    } 
#endif


#if false // Задание 5
    class Employee
    {
        private string fullName;
        private DateTime dateOfBirth;
        private string contactPhone;
        private string workEmail;
        private string position;
        private string jobDescription;

        public void SetFullName(string name)
        {
            fullName = name;
        }

        public string GetFullName()
        {
            return fullName;
        }

        public void SetDateOfBirth(DateTime birthDate)
        {
            dateOfBirth = birthDate;
        }

        public DateTime GetDateOfBirth()
        {
            return dateOfBirth;
        }

        public void SetContactPhone(string phone)
        {
            contactPhone = phone;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public void SetWorkEmail(string email)
        {
            workEmail = email;
        }

        public string GetWorkEmail()
        {
            return workEmail;
        }

        public void SetPosition(string positionName)
        {
            position = positionName;
        }

        public string GetPosition()
        {
            return position;
        }

        public void SetJobDescription(string description)
        {
            jobDescription = description;
        }

        public string GetJobDescription()
        {
            return jobDescription;
        }

        public void InputData()
        {
            Console.WriteLine("Введите ФИО:");
            fullName = Console.ReadLine();

            Console.WriteLine("Введите дату рождения (в формате ДД.ММ.ГГГГ):");
            string birthDateStr = Console.ReadLine();
            dateOfBirth = DateTime.ParseExact(birthDateStr, "dd.MM.yyyy", null);

            Console.WriteLine("Введите контактный телефон:");
            contactPhone = Console.ReadLine();

            Console.WriteLine("Введите рабочий email:");
            workEmail = Console.ReadLine();

            Console.WriteLine("Введите должность:");
            position = Console.ReadLine();

            Console.WriteLine("Введите описание служебных обязанностей:");
            jobDescription = Console.ReadLine();
        }

        public void OutputData()
        {
            Console.WriteLine("ФИО: " + fullName);
            Console.WriteLine("Дата рождения: " + dateOfBirth.ToString("dd.MM.yyyy"));
            Console.WriteLine("Контактный телефон: " + contactPhone);
            Console.WriteLine("Рабочий email: " + workEmail);
            Console.WriteLine("Должность: " + position);
            Console.WriteLine("Описание служебных обязанностей: " + jobDescription);
        }
    }

    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee.InputData();
            Console.WriteLine();
            employee.OutputData();
        }
    } 
#endif

}
