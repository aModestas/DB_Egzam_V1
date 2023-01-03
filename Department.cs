using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Egzam_V1
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public Department() { }
        public Department(string name, string address, List<Student> students, List<Course> courses)
        {
            Name = name;
            Address = address;
            Students = students;
            Courses = courses;
        }
        public Department(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
