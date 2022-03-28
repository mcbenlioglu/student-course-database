using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PGRep
{
    public interface IStudentRepository
    {

        Student InsertStudent(Student student);
        Course InsertCourse(Course course);
        Student UpdateStudent(Student chstudent);
        Course UpdateCourse(Course chcourse);
        Student DeleteStudent(int Id);
        Course DeleteCourse(String courseCode);

    }
}
