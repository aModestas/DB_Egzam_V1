using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Egzam_V1
{
    public class AddDepartment
    {
        public void addDepartment()
        {
            StudentContext context = new StudentContext();
            var medicineDepartment = new Department("Medicine", "City corner 5",
                new List<Student>() { new Student() { Name = "Tom", LastName = "Scott", DateOfBirth = new DateTime(1998, 5, 16), Grade = "Senior" } }, 
                new List<Course> { new Course() { Name = "Biology", Difficulty = "Advanced", Length = 2 } });
            context.Departments.Add(medicineDepartment);
            context.SaveChanges();
        }
        public void addBasicDepartment()
        {
            StudentContext context = new StudentContext();
            var itDepartment = new Department("IT Studies", "Student Blv. 18");
            context.Departments.Add(itDepartment);
            context.SaveChanges();
        }
    }
}
