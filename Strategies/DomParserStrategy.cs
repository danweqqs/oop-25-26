using Labs2.Models;
using System.Xml;

namespace Labs2.Strategies;

public class DomParserStrategy : IParserStrategy
{
    public List<StudentInfo> Parse(string filePath, string attribute, string keyword)
    {
        XmlDocument doc = new();
        doc.Load(filePath);

        List<StudentInfo> results = new();
        var students = doc.GetElementsByTagName("student");

        foreach (XmlNode s in students)
        {
            string? attr = s.Attributes?[attribute]?.Value;

            if (attr != null &&
                attr.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                string name = s["name"]?.InnerText ?? "";

                foreach (XmlNode subj in s.SelectNodes(".//subject")!)
                {
                    results.Add(new StudentInfo
                    {
                        Name = name,
                        AttributeValue = attr,
                        Subject = subj.InnerText,
                        Score = subj.Attributes?["score"]?.Value ?? "-"
                    });
                }
            }
        }
        return results;
    }
}