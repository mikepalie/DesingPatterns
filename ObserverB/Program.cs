using System;
using System.Collections.Generic;

namespace ObserverB
{
    public class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course("JB13");
            Course c2 = new Course("CB14");
            Course c3 = new Course("CB15");

            Assignment a1 = new Assignment() { Title = "HTML" };
            Assignment a2 = new Assignment() { Title = "CSS" };
            Assignment a3 = new Assignment() { Title = "JAVA" };
            Assignment a4 = new Assignment() { Title = "JAVASCRIPT" };

            Student s1 = new Student() { Name = "Mixalis" };
            Student s2 = new Student() { Name = "Makis" };
            Student s3 = new Student() { Name = "Lakis" };
            Student s4 = new Student() { Name = "Fanis" };
            Student s5 = new Student() { Name = "Goofy" };

            c1.AttachRange(s1, s2);
            c2.AttachRange(s1, s3, s4);
            c3.AttachRange(s1, s5);

            c1.AddAssignment(a1);
            c2.AddAssignment(a2);
            c3.AddAssignment(a3);
            c3.AddAssignment(a4);

            Console.WriteLine("=============================");

            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5 };

            foreach (var stu in students)
            {
                Console.Write(stu.Name);
                foreach (var ass in stu.Assignments)
                {
                    Console.WriteLine("\t\t" + ass.Title);
                }
            }



            Console.ReadKey();
        }
    }

    abstract  class CourseSubject
    {
        public string Name { get; set; }
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Student> Students { get; set; } = new List<Student>();//Observers

        public CourseSubject(string name)
        {
            Name = name;
        }

        public void Attach(Student student)
        {
            Students.Add(student);
        }

        public void AttachRange(params Student[] students)
        {
            foreach (Student student in students)
            {
                Students.Add(student);
            }
        }

        public void Detach(Student student)
        {
            Students.Remove(student);
        }

        public void DetachAll()
        {
            Students.Clear(); 
        }

        public void Notify(Assignment ass)
        {
            //Console.WriteLine($"Notifying.....{ass.Title}");
            foreach (Student stu in Students)
            {
                stu.Update(ass);
            }
        }

        public void AddAssignment(Assignment ass)
        {
            Assignments.Add(ass);
            Notify(ass);
        }


    }




    class Course : CourseSubject
    {
        public Course(string name): base(name)
        {

        }

    }

    interface IStudent
    {
        void Update(Assignment ass);
    }


    class Student : IStudent
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public void Update(Assignment ass)
        {
            Console.WriteLine($"Dear {Name}, the assignment {ass.Title} has been added!");
            Assignments.Add(ass);
        }
    }

    class Assignment
    {
        public string Title { get; set; }
        public Course Course { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
