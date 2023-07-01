using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_C_Sharp
{

    class HW_5
    {
#if false // Задание 1
        static void DisplaySquare(int sideLength, char symbol)
        {
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        } 
#endif


#if false // Задание 2
        static bool IsPalindrome(int number)
        {
            int reversedNumber = 0;
            int originalNumber = number;
        
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }
        
            return originalNumber == reversedNumber;
        }
#endif

#if false // Задание 3
        static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            List<int> resultList = new List<int>();
        
            foreach (int num in originalArray)
            {
                if (!filterArray.Contains(num))
                {
                    resultList.Add(num);
                }
            }
        
            return resultList.ToArray();
        }
#endif

#if false // Задание 4
        class Website
        {
            private string name;
            private string url;
            private string description;
            private string ipAddress;
        
            public void SetName(string name)
            {
                this.name = name;
            }
        
            public string GetName()
            {
                return name;
            }
        
            public void SetUrl(string url)
            {
                this.url = url;
            }
        
            public string GetUrl()
            {
                return url;
            }
        
            public void SetDescription(string description)
            {
                this.description = description;
            }
        
            public string GetDescription()
            {
                return description;
            }
        
            public void SetIpAddress(string ipAddress)
            {
                this.ipAddress = ipAddress;
            }
        
            public string GetIpAddress()
            {
                return ipAddress;
            }
        
            public void InputData()
            {
                Console.WriteLine("Enter website name:");
                name = Console.ReadLine();
        
                Console.WriteLine("Enter website URL:");
                url = Console.ReadLine();
        
                Console.WriteLine("Enter website description:");
                description = Console.ReadLine();
        
                Console.WriteLine("Enter website IP address:");
                ipAddress = Console.ReadLine();
            }
        
            public void DisplayData()
            {
                Console.WriteLine("Website Name: " + name);
                Console.WriteLine("Website URL: " + url);
                Console.WriteLine("Website Description: " + description);
                Console.WriteLine("Website IP Address: " + ipAddress);
            }
        }
#endif

#if false // Задание 5
        class Magazine
        {
            private string name;
            private int yearFounded;
            private string description;
            private string contactPhone;
            private string contactEmail;
        
            public void SetName(string name)
            {
                this.name = name;
            }
        
            public string GetName()
            {
                return name;
            }
        
            public void SetYearFounded(int year)
            {
                yearFounded = year;
            }
        
            public int GetYearFounded()
            {
                return yearFounded;
            }
        
            public void SetDescription(string description)
            {
                this.description = description;
            }
        
            public string GetDescription()
            {
                return description;
            }
        
            public void SetContactPhone(string phone)
            {
                contactPhone = phone;
            }
        
            public string GetContactPhone()
            {
                return contactPhone;
            }
        
            public void SetContactEmail(string email)
            {
                contactEmail = email;
            }
        
            public string GetContactEmail()
            {
                return contactEmail;
            }
        
            public void InputData()
            {
                Console.WriteLine("Enter magazine name:");
                name = Console.ReadLine();
        
                Console.WriteLine("Enter year founded:");
                yearFounded = int.Parse(Console.ReadLine());
        
                Console.WriteLine("Enter magazine description:");
                description = Console.ReadLine();
        
                Console.WriteLine("Enter contact phone:");
                contactPhone = Console.ReadLine();
        
                Console.WriteLine("Enter contact email:");
                contactEmail = Console.ReadLine();
            }
        
            public void DisplayData()
            {
                Console.WriteLine("Magazine Name: " + name);
                Console.WriteLine("Year Founded: " + yearFounded);
                Console.WriteLine("Magazine Description: " + description);
                Console.WriteLine("Contact Phone: " + contactPhone);
                Console.WriteLine("Contact Email: " + contactEmail);
            }
        }
#endif
    }
}
