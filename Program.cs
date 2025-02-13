using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using System.Xml.Linq;


public class Rectangle
{
    public double Length;
    public double Width;
    public static int ERectangles;


    public Rectangle()
    {
        Length = 0;
        Width = 0;
        ERectangles++;
    }

    // Конструктор с параметрами
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
        ERectangles++;
    }

    // Конструктор копирования
    public Rectangle(Rectangle other)
    {
        Length = other.Length;
        Width = other.Width;
        ERectangles++;
    }

    // Статический конструктор
    static Rectangle()
    {
        ERectangles = 0;
    }

    // Деструктор
    ~Rectangle()
    {
        ERectangles--;
        Console.WriteLine($"Прямоугольник удален. Всего осталось: {ERectangles}");
    }

    public double GetArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle num1 = new Rectangle();
        Console.WriteLine($"Прямоугольник 1: Длина={num1.Length}, Ширина={num1.Width}, Площадь={num1.GetArea()}");

        Rectangle num2 = new Rectangle(5, 3);
        Console.WriteLine($"Прямоугольник 2: Длина={num2.Length}, Ширина={num2.Width}, Площадь={num2.GetArea()}");

        Rectangle num3 = new Rectangle(num2);
        Console.WriteLine($"Прямоугольник 3: Длина={num3.Length}, Ширина={num3.Width}, Площадь={num3.GetArea()}");

        Console.WriteLine($"Всего прямоугольников: {Rectangle.ERectangles}");

    }

}