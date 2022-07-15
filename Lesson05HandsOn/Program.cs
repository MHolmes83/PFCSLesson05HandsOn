using System;

namespace Lesson05HandsOn
{
    public class Person
    {
        string firstName;
        string lastName;
        int age;

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

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Attempted to set an invalid value. Set age to 0 instead.");
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }
        
    public Person()
        {
            firstName = "";
            lastName = "";
            age = 0;
        }

    public Person(string personFirstName, string personLastName, int personAge)
        {
            firstName = personFirstName;
            lastName = personLastName;
            age = personAge;

            if (age < 0)
            {
                Console.WriteLine("Attempted to set age to an invalid value. Set age to 0 instead.");

                age = 0;
            }

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old.");
        }   
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Henry";
            person1.LastName = "Boswald";
            person1.Age = 33;

            person2.FirstName = "Lola";
            person2.LastName = "Boswald";
            person2.Age = 31;

            Console.WriteLine(person1.FirstName + " " + person1.LastName + " is " + person1.Age + " years old.");

            Console.WriteLine(person2.FirstName + " " + person2.LastName + " is " + person2.Age + " years old.");

            Person person3 = new Person("Emilia", "Hill", -42);
            Person person4 = new Person("Lucius", "Hill", 45);
        }
    }
}