using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_C_Sharp
{
    class HW_10
    {
    }
#if false // Задание 5 и 1
    class Employee
    {
        private string fullName;
        private decimal salary;

        public Employee(string fullName, decimal salary)
        {
            this.fullName = fullName;
            this.salary = salary;
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public static Employee operator +(Employee employee, decimal increaseAmount)
        {
            employee.Salary += increaseAmount;
            return employee;
        }

        public static Employee operator -(Employee employee, decimal decreaseAmount)
        {
            employee.Salary -= decreaseAmount;
            return employee;
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Salary == employee2.Salary;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Salary != employee2.Salary;
        }

        public static bool operator <(Employee employee1, Employee employee2)
        {
            return employee1.Salary < employee2.Salary;
        }

        public static bool operator >(Employee employee1, Employee employee2)
        {
            return employee1.Salary > employee2.Salary;
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee otherEmployee)
            {
                return this.Salary == otherEmployee.Salary;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }
    }

    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee("John Smith", 5000);
            Employee employee2 = new Employee("Jane Doe", 6000);

            Console.WriteLine("Зарплата сотрудника 1: " + employee1.Salary);
            Console.WriteLine("Зарплата сотрудника 2: " + employee2.Salary);

            Console.WriteLine("Увеличение зарплаты сотрудника 1 на 1000...");
            employee1 += 1000;

            Console.WriteLine("Зарплата сотрудника 1 после увеличения: " + employee1.Salary);

            Console.WriteLine("Уменьшение зарплаты сотрудника 2 на 2000...");
            employee2 -= 2000;

            Console.WriteLine("Зарплата сотрудника 2 после уменьшения: " + employee2.Salary);

            Console.WriteLine("Проверка на равенство зарплат сотрудников 1 и 2...");
            if (employee1 == employee2)
            {
                Console.WriteLine("Зарплата сотрудников 1 и 2 равна");
            }
            else
            {
                Console.WriteLine("Зарплата сотрудников 1 и 2 не равна");
            }

            Console.WriteLine("Проверка на неравенство зарплат сотрудников 1 и 2...");
            if (employee1 != employee2)
            {
                Console.WriteLine("Зарплата сотрудников 1 и 2 не равна");
            }
            else
            {
                Console.WriteLine("Зарплата сотрудников 1 и 2 равна");
            }

            Console.WriteLine("Проверка, кто имеет большую зарплату...");
            if (employee1 > employee2)
            {
                Console.WriteLine("У сотрудника 1 большая зарплата");
            }
            else if (employee1 < employee2)
            {
                Console.WriteLine("У сотрудника 2 большая зарплата");
            }
            else
            {
                Console.WriteLine("Зарплата сотрудников 1 и 2 равна");
            }

            Console.WriteLine("Проверка метода Equals для сравнения зарплат...");
            if (employee1.Equals(employee2))
            {
                Console.WriteLine("Зарплата сотрудников 1 и 2 равна");
            }
            else
            {
                Console.WriteLine("Зарплата сотрудников 1 и 2 не равна");
            }
        }
    } 
#endif
}
