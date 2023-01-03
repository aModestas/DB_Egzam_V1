using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Egzam_V1
{
    public class ReturnAllCoursesForStudent
    {
        public void GetAllCoursesForStudent(int studentID)
        {
            StudentContext studentContext = new StudentContext();
            var studentCourses = studentContext.Students.Where(s => s.Id == studentID).Include(d => d.Department).ThenInclude(x => x.Courses).ToList();
            foreach (var student in studentCourses)
            {
                Console.WriteLine($"The student [{student.Id}]{student.Name} {student.LastName} currently attends these courses:");
                foreach (var course in student.Department.Courses)
                {
                    Console.WriteLine($"[{course.Id}]{course.Name} which is a {course.Difficulty} level course that takes {course.Length} years");
                }
            }
        }
    }
}
