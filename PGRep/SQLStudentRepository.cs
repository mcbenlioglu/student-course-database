using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGRep
{
    public class SQLStudentRepository : IStudentRepository
    {
        public readonly AppDbContext context;
        public SQLStudentRepository(AppDbContext context)
        {
            this.context = context;
        }
        
        public Course DeleteCourse(string courseCode)
        {
            Course course = context.Courses.Find(courseCode);
            if (course != null)
            {
                context.Remove(course);
                context.SaveChanges();
            }
            return course;
        }

        public Student DeleteStudent(int Id)
        {
            Student student = context.Students.Find(Id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
            return student;
        }

        public Course InsertCourse(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
            return course;

        }

        public Student InsertStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }

        public Course UpdateCourse(Course chcourse)
        {
            var course = context.Courses.Attach(chcourse);
            course.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return chcourse;
        }

        public Student UpdateStudent(Student chstudent)
        {
            var student = context.Students.Attach(chstudent);
            student.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return chstudent;
        }
    }
}
