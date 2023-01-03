using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Egzam_V1
{
    public class ReturnDepartmentCourses
    {
        public void GetAllDepartmentCourses(int depID)
        {
            StudentContext studentContext = new StudentContext();
            var courseList = studentContext.Courses.Include(x => x.Departments);
            foreach (var course in courseList)
            {
                foreach (var dep in course.Departments)
                {
                    if(dep.Id == depID)
                    {
                        Console.WriteLine($"The course [{course.Id}]{course.Name} is assigned to the [{dep.Id}]{dep.Name} department");
                    }
                }
            }
        }
    }
}
