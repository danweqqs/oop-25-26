using System;
using System.Collections.Generic;

abstract class Worker { 
    public string Name { get; set; }
    public string Position { get; set; }
    public string WorkDay { get; set; }

    public Worker(string name)
    {
        Name = name;
        WorkDay = "";
    }

    public void Call()
    {
        WorkDay += "Call;";
    }

    public void WriteCode()
    {
        WorkDay += "Coding;";
    }

    public void Relax()
    {
        WorkDay += "Relax;";
    }

    public abstract void FillWorkDay();
}

class Developer : Worker {
    public Developer(string name) : base(name)
    {
        Position = "Developer";
    }

    public override void FillWorkDay()
    {
        WriteCode();
        Call();
        Relax();
        WriteCode();
    }
}

class Manager : Worker {
    private Random random = new Random();

    public Manager(string name) : base(name)
    {
        Position = "Manager";
    }

    public override void FillWorkDay()
    {
        int firstCalls = random.Next(1, 11); // від 1 до 10
        for (int i = 0; i < firstCalls; i++)
            Call();

        Relax();

        int secondCalls = random.Next(1, 6); // від 1 до 5
        for (int i = 0; i < secondCalls; i++)
            Call();
    }
}

class Team {
    public string Name { get; set; }
    private List<Worker> workers;

    public Team(string name)
    {
        Name = name;
        workers = new List<Worker>();
    }

    public void AddWorker(Worker worker)
    {
        workers.Add(worker);
    }

    public void ShowTeamInfo()
    {
        Console.WriteLine($"Team: {Name}");
        Console.WriteLine("Employees:");
        foreach (var w in workers)
        {
            Console.WriteLine($"- {w.Name}");
        }
    }

    public void ShowDetailedInfo()
    {
        Console.WriteLine($"Team: {Name}");
        Console.WriteLine("Detailed information:");
        foreach (var w in workers)
        {
            Console.WriteLine($"{w.Name} - {w.Position} - {w.WorkDay}");
        }
    }
}

internal class Program {
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Team team = new Team("Tech Titans");
        Developer dev = new Developer("Employee 1");
        dev.FillWorkDay();

        Manager man = new Manager("Employee 2");
        man.FillWorkDay();

        team.AddWorker(dev);
        team.AddWorker(man);

        team.ShowTeamInfo();
        Console.WriteLine();
        team.ShowDetailedInfo();
        Console.ReadKey();
    }
}