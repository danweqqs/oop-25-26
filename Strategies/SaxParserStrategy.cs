using Labs2.Models;
using System.Xml;

namespace Labs2.Strategies;

public class SaxParserStrategy : IParserStrategy
{
    public List<StudentInfo> Parse(string filePath, string attribute, string keyword)
    {
        List<StudentInfo> results = new();

        using XmlReader reader = XmlReader.Create(filePath);

        bool matchingStudent = false;
        string currentName = "";
        string currentAttr = "";

        while (reader.Read())
        {
            if (reader.NodeType == XmlNodeType.Element && reader.Name == "student")
            {
                currentAttr = reader.GetAttribute(attribute) ?? "";
                matchingStudent = currentAttr.Contains(keyword, StringComparison.OrdinalIgnoreCase);
            }

            if (matchingStudent && reader.NodeType == XmlNodeType.Element && reader.Name == "name")
            {
                currentName = reader.ReadElementContentAsString();
            }

            if (matchingStudent && reader.NodeType == XmlNodeType.Element && reader.Name == "subject")
            {
                string subject = reader.ReadElementContentAsString();
                string score = reader.GetAttribute("score") ?? "-";

                results.Add(new StudentInfo
                {
                    Name = currentName,
                    AttributeValue = currentAttr,
                    Subject = subject,
                    Score = score
                });
            }
        }
        return results;
    }
}