using Npgsql;
using PGRep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGdemo
{
    class main
    {
        static void Main(string[] args)
        {

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=postgres; " +
               "Password=admin;Database=SchoolDBM;");

            SQLStudentRepository rep = new SQLStudentRepository(conn);
            int command;

            Console.WriteLine("Enter a number from the list below: ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1- Add a student.");
            Console.WriteLine("2- Add a course.");
            Console.WriteLine("3- Remove a student from the list.");
            Console.WriteLine("4- Remove a course from the list.");
            Console.WriteLine("5- Update a student.");
            Console.WriteLine("6- Update a course.");
            Console.WriteLine("7- Assign a student to a course.");
            Console.WriteLine("8- See this list again.");
            Console.WriteLine("9- Exit.");
            Console.WriteLine("------------------------------------");

            do
            {
                command = Convert.ToInt32(Console.ReadLine());
                conn.Open();
                switch (command)
                {
                    case 1:
                        Console.WriteLine("Please enter the information of the student you want to add.");
                        Console.Write("Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Name, Surname: ");
                        String fullname = Console.ReadLine();

                        Student st = new Student(fullname, id);

                        rep.insertStudent(st);
                        break;
                    case 2:
                        Console.WriteLine("Please enter the information of the course you want to add.");
                        Console.Write("Course code: ");
                        String courseCode = Console.ReadLine();
                        Console.Write("Course name: ");
                        String courseName = Console.ReadLine();

                        que.insertCourse(courseCode, courseName);
                        break;
                    case 3:
                        Console.WriteLine("Please enter the Id number of the student you want to remove.");
                        Console.Write("Id: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        que.deleteStudent(id);
                        break;
                    case 4:
                        Console.WriteLine("Please enter the code of the course you want to remove.");
                        Console.Write("Course Code: ");
                        courseCode = Console.ReadLine();

                        que.deleteCourse(courseCode);
                        break;
                    case 5:
                        Console.WriteLine("Please enter the name of the student you want to update.");
                        Console.Write("Name, Surname: ");
                        String oldName = Console.ReadLine();
                        Console.WriteLine("Please enter the new name of the student.");
                        Console.Write("Name, Surname: ");
                        String newName = Console.ReadLine();

                        que.updateStudent(oldName, newName);
                        break;
                    case 6:
                        Console.WriteLine("Please enter the name of the course you want to update.");

                        Console.Write("Course Name: ");
                        String oldCourseName = Console.ReadLine();
                        Console.WriteLine("Please enter the new name of the course.");
                        Console.Write("Course Name: ");
                        String newCourseName = Console.ReadLine();

                        que.updateCourse(oldCourseName, newCourseName);
                        break;
                    case 7:
                        Console.WriteLine("Please enter the Id number of the student you want to enroll to a course.");
                        Console.Write("Id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the code of the course you want to enroll the student in.");
                        Console.Write("Course Code: ");
                        courseCode = Console.ReadLine();

                        que.assignStudent(id, courseCode);
                        break;
                    case 8:
                        Console.WriteLine("Enter a number from the list below: ");
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("1- Add a student.");
                        Console.WriteLine("2- Add a course.");
                        Console.WriteLine("3- Remove a student from the list.");
                        Console.WriteLine("4- Remove a course from the list.");
                        Console.WriteLine("5- Update a student.");
                        Console.WriteLine("6- Update a course.");
                        Console.WriteLine("7- Show all students.");
                        Console.WriteLine("8- Show all courses.");
                        Console.WriteLine("9- See this list again.");
                        Console.WriteLine("10- Exit.");
                        Console.WriteLine("------------------------------------");
                        break;
                    default:
                        if (command != 9)
                        {
                            Console.WriteLine("Invalid input! Please choose a number from 0 to 9.");
                        }
                        break;
                }

            } while (command != 9);
            conn.Close();
        }


    }
}
