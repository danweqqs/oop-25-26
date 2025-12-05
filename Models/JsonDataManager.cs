using System.Text.Json;

namespace labs3.Models
{
    public static class JsonDataManager
    {
        public static string FilePath { get; set; } = "students_data.json";

        public static List<Student> LoadData()
        {
            if (!File.Exists(FilePath))
                return new List<Student>();

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();
        }

        public static void SaveData(List<Student> students)
        {
            string json = JsonSerializer.Serialize(students, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(FilePath, json);
        }
    }
}