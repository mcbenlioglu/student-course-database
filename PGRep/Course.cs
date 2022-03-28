using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGRep
{
    public class Course
    {
        public String courseCode { get; set; }
        public String courseName { get; set; }

        public Course(String courseCode, String courseName)
        {
            this.courseCode = courseCode;
            this.courseName = courseName;
        }
    }
}
