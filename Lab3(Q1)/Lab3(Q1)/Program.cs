using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Q1_
{

    public class Course
    {
        private string courseName;
        private string instructorname;
        private double grade;
        private string instructorName;
        private string coursename;

        public string getCourseName()
        {
            return courseName;
        }

        public string getInstructorName()
        {
            return instructorname;
        }

        public void setCourseName(string courseN)
        {
            courseName = courseN;
        }

        public void setInstructorName(String Name)
        {
            if (Name != "") { }
            instructorname = Name;
        }
        public void setgrade(double Grade)
        {
            this.grade = g;
        }

        private string CalculateLetterGrade(double g)
        {
            if (g > 75)
            {
                return "A";
            }
            else if (g > 65)
            {
                return "B";
            }
            else if (g > 55)
            {
                return "C";
            }
            else if (g > 45)
            {
                return "D";
            }
            else
            {
                return ("F");
            }
        }

        public void pirntCourseInfo()
        {
            Console.WriteLine("course name is: " + coursename);
            Console.WriteLine("Instructor is: " + instructorName);
            Console.WriteLine("Grade: " + CalculateLetterGrade(grade));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NSBM Lab Practiclass");
            Course course = new Course();
            course.setCourseName("C#");
            course.setInstructorName("srimal");
            course.setgrade(67);

            Console.WriteLine("Course name: " + course.getCourseName());
        }
    }
}
