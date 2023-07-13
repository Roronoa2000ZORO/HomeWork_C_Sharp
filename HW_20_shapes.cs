using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_C_Sharp
{
    class HW_20_shapes
    {
    }

    // Абстрактный класс базовой фигуры
    public abstract class Shape
    {
        public ConsoleColor Color { get; set; }

        public abstract void Draw();
    }

    // Производные классы для конкретных фигур
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("Прямоугольник");
        }
    }

    public class Diamond : Shape
    {
        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("Ромб");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("Треугольник");
        }
    }

    public class Trapezoid : Shape
    {
        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("Трапеция");
        }
    }

    public class Polygon : Shape
    {
        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("Многоугольник");
        }
    }

    // Фабрика для создания объектов фигур
    public static class ShapeFactory
    {
        public static Shape CreateRectangle()
        {
            return new Rectangle();
        }

        public static Shape CreateDiamond()
        {
            return new Diamond();
        }

        public static Shape CreateTriangle()
        {
            return new Triangle();
        }

        public static Shape CreateTrapezoid()
        {
            return new Trapezoid();
        }

        public static Shape CreatePolygon()
        {
            return new Polygon();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> selectedShapes = new List<Shape>();

            // Выбор фигур пользователем
            Console.WriteLine("Выберите фигуры (введите номер):");
            Console.WriteLine("1. Прямоугольник");
            Console.WriteLine("2. Ромб");
            Console.WriteLine("3. Треугольник");
            Console.WriteLine("4. Трапеция");
            Console.WriteLine("5. Многоугольник");

            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out int choice))
                {
                    Shape shape = null;

                    switch (choice)
                    {
                        case 1:
                            shape = ShapeFactory.CreateRectangle();
                            break;
                        case 2:
                            shape = ShapeFactory.CreateDiamond();
                            break;
                        case 3:
                            shape = ShapeFactory.CreateTriangle();
                            break;
                        case 4:
                            shape = ShapeFactory.CreateTrapezoid();
                            break;
                        case 5:
                            shape = ShapeFactory.CreatePolygon();
                            break;
                        default:
                            Console.WriteLine("Некорректный выбор.");
                            break;
                    }

                    if (shape != null)
                    {
                        // Выбор цвета для фигуры
                        Console.WriteLine("Выберите цвет для фигуры:");
                        Console.WriteLine("1. Красный");
                        Console.WriteLine("2. Синий");
                        Console.WriteLine("3. Зеленый");
                        Console.WriteLine("4. Желтый");

                        input = Console.ReadLine();
                        ConsoleColor color;

                        switch (input)
                        {
                            case "1":
                                color = ConsoleColor.Red;
                                break;
                            case "2":
                                color = ConsoleColor.Blue;
                                break;
                            case "3":
                                color = ConsoleColor.Green;
                                break;
                            case "4":
                                color = ConsoleColor.Yellow;
                                break;
                            default:
                                Console.WriteLine("Некорректный выбор цвета.");
                                color = ConsoleColor.White;
                                break;
                        }

                        shape.Color = color;
                        selectedShapes.Add(shape);
                    }
                }

                input = Console.ReadLine();
            }

            // Отображение выбранных фигур
            Console.WriteLine("Выбранные фигуры:");
            foreach (var shape in selectedShapes)
            {
                shape.Draw();
            }
        }
    }
}
