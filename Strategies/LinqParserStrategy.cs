using Labs2.Models;
using System.Xml.Linq;

namespace Labs2.Strategies;

public class LinqParserStrategy : IParserStrategy
{
    public List<StudentInfo> Parse(string filePath, string attribute, string keyword)
    {
        var doc = XDocument.Load(filePath);

        var students = doc.Descendants("student")
            .Where(s => ((string?)s.Attribute(attribute))?
                .Contains(keyword, StringComparison.OrdinalIgnoreCase) == true)
            .ToList();

        List<StudentInfo> results = new();

        foreach (var s in students)
        {
            string name = s.Element("name")?.Value ?? "";
            string attr = s.Attribute(attribute)?.Value ?? "";

            foreach (var subj in s.Descendants("subject"))
            {
                results.Add(new StudentInfo
                {
                    Name = name,
                    AttributeValue = attr,
                    Subject = subj.Value,
                    Score = subj.Attribute("score")?.Value ?? "-"
                });
            }
        }
        return results;
    }
}