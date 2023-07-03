using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_C_Sharp
{
#if false // Задание 1
    interface IPart
    {
        void Build();
    }

    interface IWorker
    {
        void Work(IPart part);
    }

    class House
    {
        private List<IPart> parts;

        public House()
        {
            parts = new List<IPart>();
        }

        public void AddPart(IPart part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Дом построен. Вот его описание:");
            foreach (var part in parts)
            {
                part.Build();
            }
        }
    }

    class Basement : IPart
    {
        public void Build()
        {
            Console.WriteLine("Фундамент построен");
        }
    }

    class Walls : IPart
    {
        public void Build()
        {
            Console.WriteLine("Стены построены");
        }
    }

    class Door : IPart
    {
        public void Build()
        {
            Console.WriteLine("Дверь построена");
        }
    }

    class Window : IPart
    {
        public void Build()
        {
            Console.WriteLine("Окно построено");
        }
    }

    class Roof : IPart
    {
        public void Build()
        {
            Console.WriteLine("Крыша построена");
        }
    }

    class Worker : IWorker
    {
        public void Work(IPart part)
        {
            part.Build();
        }
    }

    class TeamLeader : IWorker
    {
        private List<IPart> completedParts;

        public TeamLeader()
        {
            completedParts = new List<IPart>();
        }

        public void Work(IPart part)
        {
            completedParts.Add(part);
            Console.WriteLine("Отчёт о выполненных работах:");
            foreach (var completedPart in completedParts)
            {
                completedPart.Build();
            }
        }
    }

    class Team
    {
        private List<IWorker> workers;

        public Team()
        {
            workers = new List<IWorker>();
        }

        public void AddWorker(IWorker worker)
        {
            workers.Add(worker);
        }

        public void BuildHouse(House house)
        {
            Basement basement = new Basement();
            house.AddPart(basement);

            foreach (var worker in workers)
            {
                worker.Work(basement);
            }

            Walls walls = new Walls();
            for (int i = 0; i < 4; i++)
            {
                house.AddPart(walls);

                foreach (var worker in workers)
                {
                    worker.Work(walls);
                }
            }

            Door door = new Door();
            house.AddPart(door);

            foreach (var worker in workers)
            {
                worker.Work(door);
            }

            Window window = new Window();
            for (int i = 0; i < 4; i++)
            {
                house.AddPart(window);

                foreach (var worker in workers)
                {
                    worker.Work(window);
                }
            }

            Roof roof = new Roof();
            house.AddPart(roof);

            foreach (var worker in workers)
            {
                worker.Work(roof);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            House house = new House();
            Team team = new Team();
            Worker worker1 = new Worker();
            Worker worker2 = new Worker();
            TeamLeader teamLeader = new TeamLeader();

            team.AddWorker(worker1);
            team.AddWorker(worker2);
            team.AddWorker(teamLeader);

            team.BuildHouse(house);

            house.Show();
        }
    } 
#endif

    class HW_11_BuildingAHouse
    {
    }
}
