using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Egzam_V1
{
    public class AddToEmptyDep
    {
        public void AddCourseToDep(int depID)
        {
            StudentContext studentContext = new StudentContext();
            var department = studentContext.Departments.Where(x => x.Id == depID).FirstOrDefault();
            List<Course> coursesToAdd = new List<Course>()
            {
                new Course(){ Name = "Multimedia", Difficulty = "Easy", Length = 1 },
                new Course(){ Name = "Graphic design", Difficulty = "Medium", Length = 2 },
                new Course(){ Name = "Programming", Difficulty = "Hard", Length = 2 },
                new Course(){ Name = "Data Science", Difficulty = "Medium", Length = 2 },
                new Course(){ Name = "3D Modeling", Difficulty = "Extreme", Length = 4 },
                new Course(){ Name = "Artificial inteligence", Difficulty = "Doctor", Length = 6 }
            };
            department.Courses = coursesToAdd;
            studentContext.SaveChanges();
        }  
    }
}
