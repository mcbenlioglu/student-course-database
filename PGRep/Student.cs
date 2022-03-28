using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGRep
{
    public class Student
    {
        public String fullname { get; set; }

        public int Id { get; set; }

        public Student(String fullname, int Id)
        {
            this.fullname = fullname;
            this.Id = Id;
        }
    }
}
