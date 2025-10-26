using System;

abstract class GeographicalObject {
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public GeographicalObject(double x, double y, string name, string description) {
        X = x;
        Y = y;
        Name = name;
        Description = description;
    }

    public virtual void GetInfo() {
        Console.WriteLine($"Назва: {Name}");
        Console.WriteLine($"Координати: {X}, {Y}");
        Console.WriteLine($"Опис: {Description}");
    }
}

class River : GeographicalObject {
    public double FlowSpeed { get; set; }
    public double Length { get; set; }

    public River(double x, double y, string name, string description, double flowSpeed, double length)
        : base(x, y, name, description) {
        FlowSpeed = flowSpeed;
        Length = length;
    }

    public override void GetInfo() {
        base.GetInfo();
        Console.WriteLine($"Швидкість течії: {FlowSpeed} см/с");
        Console.WriteLine($"Довжина: {Length} км");
    }
}

class Mountain : GeographicalObject {
    public double HighestPoint { get; set; }

    public Mountain(double x, double y, string name, string description, double highestPoint)
        : base(x, y, name, description) {
        HighestPoint = highestPoint;
    }

    public override void GetInfo() {
        base.GetInfo();
        Console.WriteLine($"Найвища точка: {HighestPoint} м");
    }
}

interface IGeographicalObject {
    double X { get; set; }
    double Y { get; set; }
    string Name { get; set; }
    string Description { get; set; }

    void GetInfo();
}

class RiverInterface : IGeographicalObject {
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double FlowSpeed { get; set; }
    public double Length { get; set; }

    public void GetInfo() {
        Console.WriteLine($"Річка: {Name}");
        Console.WriteLine($"Координати: {X}, {Y}");
        Console.WriteLine($"Довжина: {Length} км");
        Console.WriteLine($"Швидкість течії: {FlowSpeed} см/с");
        Console.WriteLine($"Опис: {Description}");
    }
}

class MountainInterface : IGeographicalObject {
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double HighestPoint { get; set; }

    public void GetInfo() {
        Console.WriteLine($"Гора: {Name}");
        Console.WriteLine($"Координати: {X}, {Y}");
        Console.WriteLine($"Найвища точка: {HighestPoint} м");
        Console.WriteLine($"Опис: {Description}");
    }
}

internal class Program {
    static void Main() {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Абстрактні класи");
        River dnipro = new River(46.30, 32.16, "Дніпро", "Найбільша річка України", 150, 2201);
        Mountain hoverla = new Mountain(48.09, 24.30, "Говерла", "Найвища гора України", 2061);

        dnipro.GetInfo();
        Console.WriteLine();
        hoverla.GetInfo();

        Console.WriteLine("\nІнтерфейси");
        RiverInterface desna = new RiverInterface {
            X = 54.35,
            Y = 33.17,
            Name = "Десна",
            Description = "Притока Дніпра",
            FlowSpeed = 120,
            Length = 1130
        };
        desna.GetInfo();

        Console.WriteLine();
        MountainInterface petros = new MountainInterface {
            X = 48.10,
            Y = 24.5,
            Name = "Петрос",
            Description = "'Молодший брат' Говерли",
            HighestPoint = 2020
        };
        petros.GetInfo();

        Console.ReadKey();
    }
}