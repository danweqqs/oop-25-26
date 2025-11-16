using Labs2.Models;
using System.Collections.Generic;

namespace Labs2.Strategies;

public interface IParserStrategy
{
    List<StudentInfo> Parse(string filePath, string attribute, string keyword);
}