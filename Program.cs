using System;

class Converter
{
    private decimal usdRate;
    private decimal eurRate;
    public Converter(decimal usd, decimal eur)
    {
        usdRate = usd;
        eurRate = eur;
    }

    public decimal FromUahToUsd(decimal amount)
    {
        return amount / usdRate;
    }

    public decimal FromUahToEur(decimal amount)
    {
        return amount / eurRate;
    }

    public decimal FromUsdToUah(decimal amount)
    {
        return amount * usdRate;
    }

    public decimal FromEurToUah(decimal amount)
    {
        return amount * eurRate;
    }
}

internal class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Converter converter = new Converter(41.45m, 43.80m);

        Console.WriteLine("Конвертація валют:");
        Console.WriteLine("1 — гривня → долар");
        Console.WriteLine("2 — гривня → євро");
        Console.WriteLine("3 — долар → гривня");
        Console.WriteLine("4 — євро → гривня");
        Console.Write("\nОберіть варіант: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Введіть суму: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        decimal result = 0;

        switch (choice)
        {
            case 1:
                result = converter.FromUahToUsd(amount);
                Console.WriteLine($"{amount} грн = {result:F2} USD");
                break;
            case 2:
                result = converter.FromUahToEur(amount);
                Console.WriteLine($"{amount} грн = {result:F2} EUR");
                break;
            case 3:
                result = converter.FromUsdToUah(amount);
                Console.WriteLine($"{amount} USD = {result:F2} грн");
                break;
            case 4:
                result = converter.FromEurToUah(amount);
                Console.WriteLine($"{amount} EUR = {result:F2} грн");
                break;
            default:
                Console.WriteLine("Невірний вибір!");
                break;
        }

        Console.ReadKey();
    }
}