using System.Text.Json;

namespace labs3.Models
{
    public static class JsonDataManager
    {
        private static string path = "students_data.json";

        public static List<Student> LoadData()
        {
            if (!File.Exists(path))
                return new List<Student>();

            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Student>>(json)!;
        }

        public static void SaveData(List<Student> students)
        {
            string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }
    }
}