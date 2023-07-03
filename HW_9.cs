using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_C_Sharp
{
    class HW_9
    {
    }

#if false // Задание 1
    class Journal
    {
        private string name;
        private int yearFounded;
        private string description;
        private string contactPhone;
        private string contactEmail;
        private int employeeCount;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int YearFounded
        {
            get { return yearFounded; }
            set { yearFounded = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }

        public string ContactEmail
        {
            get { return contactEmail; }
            set { contactEmail = value; }
        }

        public int EmployeeCount
        {
            get { return employeeCount; }
            set { employeeCount = value; }
        }

        public Journal(string name, int yearFounded, string description, string contactPhone, string contactEmail, int employeeCount)
        {
            Name = name;
            YearFounded = yearFounded;
            Description = description;
            ContactPhone = contactPhone;
            ContactEmail = contactEmail;
            EmployeeCount = employeeCount;
        }

        public static Journal operator +(Journal journal, int count)
        {
            journal.EmployeeCount += count;
            return journal;
        }

        public static Journal operator -(Journal journal, int count)
        {
            journal.EmployeeCount -= count;
            return journal;
        }

        public static bool operator ==(Journal journal1, Journal journal2)
        {
            return journal1.EmployeeCount == journal2.EmployeeCount;
        }

        public static bool operator !=(Journal journal1, Journal journal2)
        {
            return journal1.EmployeeCount != journal2.EmployeeCount;
        }

        public static bool operator <(Journal journal1, Journal journal2)
        {
            return journal1.EmployeeCount < journal2.EmployeeCount;
        }

        public static bool operator >(Journal journal1, Journal journal2)
        {
            return journal1.EmployeeCount > journal2.EmployeeCount;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Journal other = (Journal)obj;
            return EmployeeCount == other.EmployeeCount;
        }

        public override int GetHashCode()
        {
            return EmployeeCount.GetHashCode();
        }

        public void PrintInfo()
        {
            Console.WriteLine("Название журнала: " + Name);
            Console.WriteLine("Год основания: " + YearFounded);
            Console.WriteLine("Описание журнала: " + Description);
            Console.WriteLine("Контактный телефон: " + ContactPhone);
            Console.WriteLine("Контактный email: " + ContactEmail);
            Console.WriteLine("Количество сотрудников: " + EmployeeCount);
        }
    }

    class Program
    {
        static void Main()
        {
            Journal journal1 = new Journal("Журнал1", 2020, "Описание1", "123456789", "journal1@example.com", 10);
            Journal journal2 = new Journal("Журнал2", 2018, "Описание2", "987654321", "journal2@example.com", 15);

            journal1.PrintInfo();
            Console.WriteLine();

            journal1 += 5;
            journal2 -= 3;

            journal1.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Журнал1 == Журнал2: " + (journal1 == journal2));
            Console.WriteLine("Журнал1 != Журнал2: " + (journal1 != journal2));
            Console.WriteLine("Журнал1 < Журнал2: " + (journal1 < journal2));
            Console.WriteLine("Журнал1 > Журнал2: " + (journal1 > journal2));
        }
    } 
#endif

#if false // Задание 2
    class Shop
    {
        private string name;
        private string address;
        private string description;
        private int employeeCount;
        private double area;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int EmployeeCount
        {
            get { return employeeCount; }
            set { employeeCount = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public Shop(string name, string address, string description, int employeeCount, double area)
        {
            Name = name;
            Address = address;
            Description = description;
            EmployeeCount = employeeCount;
            Area = area;
        }

        public static Shop operator +(Shop shop, double increase)
        {
            shop.Area += increase;
            return shop;
        }

        public static Shop operator -(Shop shop, double decrease)
        {
            shop.Area -= decrease;
            return shop;
        }

        public static bool operator ==(Shop shop1, Shop shop2)
        {
            return shop1.Area == shop2.Area;
        }

        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return shop1.Area != shop2.Area;
        }

        public static bool operator <(Shop shop1, Shop shop2)
        {
            return shop1.Area < shop2.Area;
        }

        public static bool operator >(Shop shop1, Shop shop2)
        {
            return shop1.Area > shop2.Area;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Shop other = (Shop)obj;
            return Area == other.Area;
        }

        public override int GetHashCode()
        {
            return Area.GetHashCode();
        }

        public void PrintInfo()
        {
            Console.WriteLine("Название магазина: " + Name);
            Console.WriteLine("Адрес: " + Address);
            Console.WriteLine("Описание: " + Description);
            Console.WriteLine("Количество сотрудников: " + EmployeeCount);
            Console.WriteLine("Площадь: " + Area);
        }
    }

    class Program
    {
        static void Main()
        {
            Shop shop1 = new Shop("Магазин1", "Адрес1", "Описание1", 10, 100.0);
            Shop shop2 = new Shop("Магазин2", "Адрес2", "Описание2", 15, 200.0);

            shop1.PrintInfo();
            Console.WriteLine();

            shop1 += 50.0;
            shop2 -= 30.0;

            shop1.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Магазин1 == Магазин2: " + (shop1 == shop2));
            Console.WriteLine("Магазин1 != Магазин2: " + (shop1 != shop2));
            Console.WriteLine("Магазин1 < Магазин2: " + (shop1 < shop2));
            Console.WriteLine("Магазин1 > Магазин2: " + (shop1 > shop2));
        }
    } 
#endif

#if false // Задание 3
    class ReadingList
    {
        private List<string> books;

        public ReadingList()
        {
            books = new List<string>();
        }

        public int Count
        {
            get { return books.Count; }
        }

        public string this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public void AddBook(string book)
        {
            books.Add(book);
        }

        public bool RemoveBook(string book)
        {
            return books.Remove(book);
        }

        public bool ContainsBook(string book)
        {
            return books.Contains(book);
        }

        public static ReadingList operator +(ReadingList readingList, string book)
        {
            readingList.AddBook(book);
            return readingList;
        }

        public static ReadingList operator -(ReadingList readingList, string book)
        {
            readingList.RemoveBook(book);
            return readingList;
        }

        public static bool operator ==(ReadingList readingList, string book)
        {
            return readingList.ContainsBook(book);
        }

        public static bool operator !=(ReadingList readingList, string book)
        {
            return !readingList.ContainsBook(book);
        }
    }

    class Program
    {
        static void Main()
        {
            ReadingList myReadingList = new ReadingList();
            myReadingList.AddBook("Book1");
            myReadingList.AddBook("Book2");
            myReadingList.AddBook("Book3");

            Console.WriteLine("Количество книг в списке: " + myReadingList.Count);

            Console.WriteLine("Книги в списке:");
            for (int i = 0; i < myReadingList.Count; i++)
            {
                Console.WriteLine(myReadingList[i]);
            }

            Console.WriteLine("Удаление книги 'Book2' из списка...");
            myReadingList.RemoveBook("Book2");

            Console.WriteLine("Количество книг в списке: " + myReadingList.Count);

            Console.WriteLine("Книги в списке:");
            for (int i = 0; i < myReadingList.Count; i++)
            {
                Console.WriteLine(myReadingList[i]);
            }

            Console.WriteLine("Добавление книги 'Book4' в список...");
            myReadingList += "Book4";

            Console.WriteLine("Количество книг в списке: " + myReadingList.Count);

            Console.WriteLine("Книги в списке:");
            for (int i = 0; i < myReadingList.Count; i++)
            {
                Console.WriteLine(myReadingList[i]);
            }

            Console.WriteLine("Проверка наличия книги 'Book3' в списке...");
            if (myReadingList == "Book3")
            {
                Console.WriteLine("Книга 'Book3' есть в списке");
            }
            else
            {
                Console.WriteLine("Книги 'Book3' нет в списке");
            }

            Console.WriteLine("Проверка наличия книги 'Book5' в списке...");
            if (myReadingList == "Book5")
            {
                Console.WriteLine("Книга 'Book5' есть в списке");
            }
            else
            {
                Console.WriteLine("Книги 'Book5' нет в списке");
            }
        }
    } 
#endif

}
