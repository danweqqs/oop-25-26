using System;

interface IShape
{
    int GetArea();
}

class Rectangle : IShape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

class Square : IShape
{
    private int _side;
    public int Side
    {
        get { return _side; }
        set { _side = value; }
    }

    public int GetArea()
    {
        return _side * _side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;
        Console.WriteLine($"Rectangle Area (5x10): {rect.GetArea()}");

        Square square = new Square();
        square.Side = 5;
        Console.WriteLine($"Square Area (5x5): {square.GetArea()}");

        Console.ReadKey();
    }
}