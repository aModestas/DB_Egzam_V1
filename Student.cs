using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Egzam_V1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Grade { get; set; }
        public Department Department { get; set; }
        public Student() { }
        public Student(string name, string lastName, DateTime dateOfBith, string grade)
        {
            Name = name;
            LastName = lastName;
            DateOfBirth = dateOfBith;
            Grade = grade;
        }

    }
}
