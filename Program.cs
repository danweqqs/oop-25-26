using System;
using System.Collections.Generic;
using Labs2.Strategies;
using Labs2.Models;

class Program
{
    static void Main()
    {
        string xmlFile = "students.xml";
        string xslFile = "students.xsl";
        string outputHtml = "output.html";

        IParserStrategy parser = null;

        while (true)
        {
            Console.WriteLine("\n=== Меню ===");
            Console.WriteLine("1. Вибрати спосіб аналізу (SAX / DOM / LINQ)");
            Console.WriteLine("2. Пошук у XML");
            Console.WriteLine("3. Очистити екран (Clear)");
            Console.WriteLine("4. Трансформувати в HTML");
            Console.WriteLine("5. Вихід");
            Console.Write("Ваш вибір: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Оберіть стратегію: sax / dom / linq:");
                string type = Console.ReadLine().ToLower();

                parser = type switch
                {
                    "sax" => new SaxParserStrategy(),
                    "dom" => new DomParserStrategy(),
                    "linq" => new LinqParserStrategy(),
                    _ => null
                };

                Console.WriteLine(parser != null
                    ? "Стратегія встановлена."
                    : "Помилка вибору.");
            }
            else if (choice == "2")
            {
                if (parser == null)
                {
                    Console.WriteLine("Спочатку виберіть стратегію!");
                    continue;
                }

                Console.Write("Введіть атрибут для пошуку (faculty / department / course / semester / id): ");
                string attribute = Console.ReadLine();

                Console.Write("Введіть ключове слово: ");
                string keyword = Console.ReadLine();

                List<StudentInfo> results = parser.Parse(xmlFile, attribute, keyword);

                Console.WriteLine("\n=== Результати ===");

                if (results.Count == 0)
                {
                    Console.WriteLine("Нічого не знайдено.");
                }
                else
                {
                    foreach (var r in results)
                    {
                        Console.WriteLine($"{r.Name} | {r.AttributeValue} | {r.Subject} | {r.Score}");
                    }
                }
            }
            else if (choice == "3")
            {
                Console.Clear();
            }
            else if (choice == "4")
            {
                HtmlTransformer.Transform(xmlFile, xslFile, outputHtml);
                Console.WriteLine("HTML створено: output.html");
            }
            else if (choice == "5")
            {
                Console.Write("Ви дійсно хочете вийти? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                    break;
            }
        }
    }
}