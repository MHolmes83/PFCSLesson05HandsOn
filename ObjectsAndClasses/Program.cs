using System;

namespace ObjectsAndClasses
{
    public class Student
    {
        string firstName;
        string lastName;
        string courseFocus;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string CourseFocus
        {
            get
            {
                return courseFocus;
            }
            set
            {
                courseFocus = value;
            }
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " has the Course Focus of " + courseFocus + ".";
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate three student objects
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student(); 

            // set the information for student 1
            student1.FirstName = "Oliver";
            student1.LastName = "Queen";
            student1.CourseFocus = "Archery";
            // set the information for student 2
            student2.FirstName = "John";
            student2.LastName = "Diggle";
            student2.CourseFocus = "Security";
            // set the information for student 3
            student3.FirstName = "Felicity";
            student3.LastName = "Smoak";
            student3.CourseFocus = "Computer Science";
            // print the information for each student
            Console.WriteLine(student1.FirstName + " " + student1.LastName + " is studying " + student1.CourseFocus + ".");
            Console.WriteLine(student2.FirstName + " " + student2.LastName + " is studying " + student2.CourseFocus + ".");
            Console.WriteLine(student3.FirstName + " " + student3.LastName + " is studying " + student3.CourseFocus + ".");
        }
    }
}