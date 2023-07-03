using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_C_Sharp
{
    class HW_12_CarRacing
    {
    }
#if false // Задание 1
    abstract class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        // Метод для перемещения автомобиля
        public void Move()
        {
            Console.WriteLine($"{Name} движется со скоростью {Speed} км/ч");
        }

        // Абстрактный метод для определения победы
        public abstract void Finish();
    }

    // Класс спортивного автомобиля
    class SportsCar : Car
    {
        public SportsCar(string name, int speed) : base(name, speed)
        {
        }

        public override void Finish()
        {
            Console.WriteLine($"{Name} победил в гонке!");
        }
    }

    // Класс легкового автомобиля
    class SedanCar : Car
    {
        public SedanCar(string name, int speed) : base(name, speed)
        {
        }

        public override void Finish()
        {
            Console.WriteLine($"{Name} пришел вторым!");
        }
    }

    // Класс грузовика
    class Truck : Car
    {
        public Truck(string name, int speed) : base(name, speed)
        {
        }

        public override void Finish()
        {
            Console.WriteLine($"{Name} пришел третьим!");
        }
    }

    // Класс автобуса
    class Bus : Car
    {
        public Bus(string name, int speed) : base(name, speed)
        {
        }

        public override void Finish()
        {
            Console.WriteLine($"{Name} пришел четвертым!");
        }
    }

    // Класс игры "Автомобильные гонки"
    class RacingGame
    {
        // Делегат для запуска автомобиля
        delegate void StartCarDelegate();

        // Событие окончания гонки
        event Action<Car> RaceFinished;

        public void StartRace()
        {
            // Создание объектов автомобилей
            SportsCar sportsCar = new SportsCar("Спортивный автомобиль", GetRandomSpeed());
            SedanCar sedanCar = new SedanCar("Легковой автомобиль", GetRandomSpeed());
            Truck truck = new Truck("Грузовик", GetRandomSpeed());
            Bus bus = new Bus("Автобус", GetRandomSpeed());

            // Подписка на событие окончания гонки
            RaceFinished += sportsCar.Finish;
            RaceFinished += sedanCar.Finish;
            RaceFinished += truck.Finish;
            RaceFinished += bus.Finish;

            // Запуск гонки
            Console.WriteLine("Гонка началась!");
            Console.WriteLine();

            while (true)
            {
                // Перемещение автомобилей
                sportsCar.Move();
                sedanCar.Move();
                truck.Move();
                bus.Move();

                Console.WriteLine();

                // Проверка условия окончания гонки
                if (sportsCar.Speed >= 100 || sedanCar.Speed >= 100 || truck.Speed >= 100 || bus.Speed >= 100)
                {
                    // Вызов события окончания гонки
                    RaceFinished?.Invoke(null);
                    break;
                }
            }
        }

        // Метод для генерации случайной скорости
        private int GetRandomSpeed()
        {
            Random random = new Random();
            return random.Next(50, 90);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RacingGame game = new RacingGame();
            game.StartRace();

            Console.ReadKey();
        }
    } 
#endif
}
