using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonExample {
    public class PublishingHouse {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Adress {get; set;}
    }

    public class Book {
        [JsonIgnore]
        public int PublishingHouseId {get; set;}
        [JsonPropertyName("Name")]
        public string Title {get; set;}
        public PublishingHouse PublishingHouse {get; set;}
    }

    internal class Program {
        static void Main() {
            string json = File.ReadAllText("books.json");
            List<Book> books = JsonSerializer.Deserialize<List<Book>>(json)!;

            Console.WriteLine("Список книжок:\n");
            foreach (var book in books) {
                Console.WriteLine($"Назва: {book.Title}");
                Console.WriteLine($"Видавництво: {book.PublishingHouse.Name}");
                Console.WriteLine($"Адреса: {book.PublishingHouse.Adress}\n");
            }

            string newJson = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("books_new.json", newJson);
        }
    }
}