using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Egzam_V1
{
    public class AddStudentsCoursesToDep
    {
        public void AddStudents(int idForDB)
        {
            StudentContext studentContext = new StudentContext();
            var department = studentContext.Departments.Where(d => d.Id == idForDB).First();
            List<Student> students = new List<Student>()
            {
                new Student(){ Name = "Ben", LastName = "Jerry", DateOfBirth = new DateTime(2000, 1, 13).Date, Grade = "Junior"  },
                new Student(){ Name = "Alice", LastName = "Wonderland", DateOfBirth = new DateTime(2002, 7, 6).Date, Grade = "Freshman"  },
                new Student(){ Name = "Yvone", LastName = "Kelly", DateOfBirth = new DateTime(1999, 3, 12).Date, Grade = "Senior"  },
                new Student(){ Name = "Jimmy", LastName = "Cooks", DateOfBirth = new DateTime(2004, 1, 1).Date, Grade = "Junior"  },
            };
            department.Students = students;
            studentContext.SaveChanges();

        }
        public void AddCourses(int idForDB)
        {
            StudentContext studentContext = new StudentContext();
            var department = studentContext.Departments.Where(d => d.Id == idForDB).First();
            List<Course> courses = new List<Course>() { 
            new Course() { Name = "Veterinary Science", Difficulty = "Expert", Length = 4,},
            new Course() { Name = "Nurse practice", Difficulty = "Medium", Length = 3 },
            new Course() { Name = "Surgery", Difficulty = "Doctor", Length = 6 }};
            department.Courses = courses;
            studentContext.SaveChanges();
            
        }
    }
}
