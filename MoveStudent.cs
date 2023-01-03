using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Egzam_V1
{
    public class MoveStudent
    {
        public void MoveStudentToDep(int studentToMoveID, int toWhichWdepID)
        {
            StudentContext studentContext = new StudentContext();
            var student = studentContext.Students.Where(x => x.Id == studentToMoveID).FirstOrDefault();
            var department = studentContext.Departments.Where(x => x.Id == toWhichWdepID).FirstOrDefault();
            department.Students = new List<Student>();
            department.Students.Add(student);
            studentContext.SaveChanges();
        }
    }
}
