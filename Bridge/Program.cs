using System;

// Иерархия реализаций
interface IColor
{
    void Fill();
}

class RedColor : IColor
{
    public void Fill()
    {
        Console.WriteLine("Залейте красным цветом");
    }
}

class BlueColor : IColor
{
    public void Fill()
    {
        Console.WriteLine("Залейте синим цветом");
    }
}

// Абстракция
abstract class Shape
{
    protected IColor color;

    public Shape(IColor color)
    {
        this.color = color;
    }

    public abstract void Draw();
}

// Реализация абстракции
class Rectangle : Shape
{
    public Rectangle(IColor color) : base(color)
    {
    }

    public override void Draw()
    {
        Console.Write("Нарисуйте прямоугольник. ");
        color.Fill();
    }
}

class Circle : Shape
{
    public Circle(IColor color) : base(color)
    {
    }

    public override void Draw()
    {
        Console.Write("Нарисуйте круг. ");
        color.Fill();
    }
}


class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[2];
        IColor red = new RedColor();
        IColor blue = new BlueColor();

        shapes[0] = new Rectangle(red);
        shapes[1] = new Circle(blue);

        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}