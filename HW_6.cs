using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_C_Sharp
{
    class HW_6
    {
#if false // Задание 1
        static void Main()
        {
            Console.WriteLine("=== Number System Converter ===");
            Console.WriteLine("1. Decimal to Binary");
            Console.WriteLine("2. Decimal to Octal");
            Console.WriteLine("3. Decimal to Hexadecimal");
            Console.WriteLine("4. Exit");
            Console.WriteLine("===============================");

            bool exit = false;

            while (!exit)
            {
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ConvertDecimalToBinary();
                        break;
                    case "2":
                        ConvertDecimalToOctal();
                        break;
                    case "3":
                        ConvertDecimalToHexadecimal();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void ConvertDecimalToBinary()
        {
            Console.Write("Enter a decimal number: ");
            if (int.TryParse(Console.ReadLine(), out int decimalNumber))
            {
                string binaryNumber = Convert.ToString(decimalNumber, 2);
                Console.WriteLine($"Binary number: {binaryNumber}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number.");
            }
        }

        static void ConvertDecimalToOctal()
        {
            Console.Write("Enter a decimal number: ");
            if (int.TryParse(Console.ReadLine(), out int decimalNumber))
            {
                string octalNumber = Convert.ToString(decimalNumber, 8);
                Console.WriteLine($"Octal number: {octalNumber}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number.");
            }
        }

        static void ConvertDecimalToHexadecimal()
        {
            Console.Write("Enter a decimal number: ");
            if (int.TryParse(Console.ReadLine(), out int decimalNumber))
            {
                string hexadecimalNumber = Convert.ToString(decimalNumber, 16);
                Console.WriteLine($"Hexadecimal number: {hexadecimalNumber}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number.");
            }
        } 
#endif

#if false // Задание 2
        static void Main()
        {
            Dictionary<string, int> wordToNumberMap = new Dictionary<string, int>
        {
            {"ноль", 0},
            {"один", 1},
            {"два", 2},
            {"три", 3},
            {"четыре", 4},
            {"пять", 5},
            {"шесть", 6},
            {"семь", 7},
            {"восемь", 8},
            {"девять", 9}
        };

            Console.Write("Введите словом цифру от 0 до 9: ");
            string inputWord = Console.ReadLine().ToLower();

            if (wordToNumberMap.TryGetValue(inputWord, out int number))
            {
                Console.WriteLine($"Цифра: {number}");
            }
            else
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите словом цифру от 0 до 9.");
            }
        } 
#endif

#if false // Задание 4
        static void Main()
        {
            Console.WriteLine("Введите логическое выражение (например, 3>2 или 7<3):");
            string input = Console.ReadLine();

            try
            {
                bool result = EvaluateExpression(input);
                Console.WriteLine($"Результат: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static bool EvaluateExpression(string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                throw new ArgumentException("Выражение не может быть пустым.");
            }

            string[] operators = { "<", ">", "<=", ">=", "==", "!=" };

            string[] tokens = expression.Split(' ');

            if (tokens.Length != 3)
            {
                throw new ArgumentException("Некорректное выражение.");
            }

            string operand1 = tokens[0];
            string operatorSymbol = tokens[1];
            string operand2 = tokens[2];

            if (!operators.Contains(operatorSymbol))
            {
                throw new ArgumentException("Некорректный оператор.");
            }

            if (!int.TryParse(operand1, out int num1) || !int.TryParse(operand2, out int num2))
            {
                throw new ArgumentException("Операнды должны быть целыми числами.");
            }

            switch (operatorSymbol)
            {
                case "<":
                    return num1 < num2;
                case ">":
                    return num1 > num2;
                case "<=":
                    return num1 <= num2;
                case ">=":
                    return num1 >= num2;
                case "==":
                    return num1 == num2;
                case "!=":
                    return num1 != num2;
                default:
                    throw new ArgumentException("Некорректный оператор.");
            }
        } 
#endif


    }

#if false // Задание 3
    class Passport
    {
        private string passportNumber;
        private string ownerFullName;
        private DateTime issueDate;

        public Passport(string passportNumber, string ownerFullName, DateTime issueDate)
        {
            if (string.IsNullOrEmpty(passportNumber))
            {
                throw new ArgumentException("Номер паспорта не может быть пустым.");
            }

            if (string.IsNullOrEmpty(ownerFullName))
            {
                throw new ArgumentException("ФИО владельца не может быть пустым.");
            }

            if (issueDate > DateTime.Now)
            {
                throw new ArgumentException("Дата выдачи паспорта не может быть в будущем.");
            }

            this.passportNumber = passportNumber;
            this.ownerFullName = ownerFullName;
            this.issueDate = issueDate;
        }

        public string PassportNumber
        {
            get { return passportNumber; }
        }

        public string OwnerFullName
        {
            get { return ownerFullName; }
        }

        public DateTime IssueDate
        {
            get { return issueDate; }
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Passport passport = new Passport("AB1234567", "Иванов Иван Иванович", new DateTime(2022, 5, 15));
                Console.WriteLine($"Номер паспорта: {passport.PassportNumber}");
                Console.WriteLine($"ФИО владельца: {passport.OwnerFullName}");
                Console.WriteLine($"Дата выдачи: {passport.IssueDate.ToShortDateString()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка инициализации паспорта: {ex.Message}");
            }
        }
    } 
#endif


}
