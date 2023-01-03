using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Egzam_V1
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public int Length { get; set; }
        public List<Department> Departments { get; set; }
        public Course() { }
        public Course(string name, string difficulty, int length)
        {
            Name = name;
            Difficulty = difficulty;
            Length = length;
        }
    }
}
