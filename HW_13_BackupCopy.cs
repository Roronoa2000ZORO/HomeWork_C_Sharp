using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_C_Sharp
{
    class HW_13_BackupCopy
    {
    }

#if false // Задание 2 «Резервная копия»
    // Абстрактный класс "Носитель информации"
    abstract class Storage
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public abstract double GetMemory();
        public abstract void CopyData(double dataSize);
        public abstract double GetFreeSpace();
        public abstract void GetDeviceInfo();
    }

    // Класс "Flash-память"
    class Flash : Storage
    {
        public double UsbSpeed { get; set; }
        public double MemorySize { get; set; }

        public override double GetMemory()
        {
            return MemorySize;
        }

        public override void CopyData(double dataSize)
        {
            double timeInSeconds = dataSize / UsbSpeed;
            TimeSpan time = TimeSpan.FromSeconds(timeInSeconds);
            Console.WriteLine($"Копирование данных на Flash-память займет {time.ToString(@"hh\:mm\:ss")}");
        }

        public override double GetFreeSpace()
        {
            // Предполагаем, что на Flash-памяти есть свободное место
            return MemorySize;
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Носитель информации: Flash-память");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Объем памяти: {MemorySize} Гб");
            Console.WriteLine($"Скорость USB: {UsbSpeed} Мб/с");
            Console.WriteLine($"Свободное место: {GetFreeSpace()} Гб");
            Console.WriteLine();
        }
    }

    // Класс "DVD-диск"
    class DVD : Storage
    {
        public double ReadWriteSpeed { get; set; }
        public string Type { get; set; }

        public override double GetMemory()
        {
            if (Type == "Односторонний")
                return 4.7;
            else if (Type == "Двусторонний")
                return 9;
            else
                return 0;
        }

        public override void CopyData(double dataSize)
        {
            double timeInSeconds = dataSize / ReadWriteSpeed;
            TimeSpan time = TimeSpan.FromSeconds(timeInSeconds);
            Console.WriteLine($"Копирование данных на DVD-диск займет {time.ToString(@"hh\:mm\:ss")}");
        }

        public override double GetFreeSpace()
        {
            // Предполагаем, что на DVD-диске есть свободное место
            return GetMemory();
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Носитель информации: DVD-диск");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Тип: {Type}");
            Console.WriteLine($"Скорость чтения/записи: {ReadWriteSpeed} Мб/с");
            Console.WriteLine($"Свободное место: {GetFreeSpace()} Гб");
            Console.WriteLine();
        }
    }

    // Класс "Съемный HDD"
    class HDD : Storage
    {
        public double UsbSpeed { get; set; }
        public int PartitionCount { get; set; }
        public double PartitionSize { get; set; }

        public override double GetMemory()
        {
            return PartitionCount * PartitionSize;
        }

        public override void CopyData(double dataSize)
        {
            double timeInSeconds = dataSize / UsbSpeed;
            TimeSpan time = TimeSpan.FromSeconds(timeInSeconds);
            Console.WriteLine($"Копирование данных на съемный HDD займет {time.ToString(@"hh\:mm\:ss")}");
        }

        public override double GetFreeSpace()
        {
            // Предполагаем, что на съемном HDD есть свободное место
            return GetMemory();
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Носитель информации: Съемный HDD");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Количество разделов: {PartitionCount}");
            Console.WriteLine($"Объем разделов: {PartitionSize} Гб");
            Console.WriteLine($"Скорость USB: {UsbSpeed} Мб/с");
            Console.WriteLine($"Свободное место: {GetFreeSpace()} Гб");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Storage[] devices = new Storage[]
            {
            new Flash { Name = "Flash Drive 1", Model = "Kingston", UsbSpeed = 100, MemorySize = 64 },
            new DVD { Name = "DVD Drive 1", Model = "Samsung", ReadWriteSpeed = 20, Type = "Односторонний" },
            new HDD { Name = "External HDD 1", Model = "Seagate", UsbSpeed = 60, PartitionCount = 2, PartitionSize = 500 }
            };

            double totalMemory = 0;
            foreach (var device in devices)
            {
                totalMemory += device.GetMemory();
                device.GetDeviceInfo();
            }

            Console.WriteLine($"Общий объем памяти всех устройств: {totalMemory} Гб");
            Console.WriteLine();

            double dataSize = 565; // Размер данных для копирования в Гб

            foreach (var device in devices)
            {
                if (device.GetFreeSpace() >= dataSize)
                {
                    device.CopyData(dataSize);
                    break;
                }
            }

            int requiredDevicesCount = (int)Math.Ceiling(dataSize / devices[0].GetFreeSpace());
            Console.WriteLine($"Необходимое количество носителей информации: {requiredDevicesCount}");

            Console.ReadKey();
        }
    } 
#endif

}
