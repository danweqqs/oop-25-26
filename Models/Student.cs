using System.Collections.Generic;

namespace labs3.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public int Course { get; set; }
        public int Semester { get; set; }
        public List<SubjectGrade> Grades { get; set; }
    }
}