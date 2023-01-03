using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Egzam_V1
{
    public class ReturnDepartmentStudents
    {
        public void GetAllDepartmentStudents(int departmentID)
        {
            StudentContext studentContext = new StudentContext();
            var studentList = studentContext.Students.Include(x => x.Department).Where(d => d.Department.Id == departmentID);
            foreach (var student in studentList)
            {
                Console.WriteLine($" The student: [{student.Id}] {student.Name} {student.LastName}, who is a {student.Grade}, belongs to the {student.Department.Name} department");
            }
        }
    }
}
