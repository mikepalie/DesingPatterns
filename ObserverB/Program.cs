using ObserverB.Entities;
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
            MiniBootcamp m1 = new MiniBootcamp("MOU2023");

            Assignment a1 = new Assignment() { Title = "HTML" };
            Assignment a2 = new Assignment() { Title = "CSS" };
            Assignment a3 = new Assignment() { Title = "JAVA" };
            Assignment a4 = new Assignment() { Title = "JAVASCRIPT" };

            Student s1 = new Student() { Name = "Mixalis" };
            Student s2 = new Student() { Name = "Makis" };
            Student s3 = new Student() { Name = "Lakis" };
            Student s4 = new Student() { Name = "Fanis" };
            Student s5 = new Student() { Name = "Goofy" };

            Trainer t1 = new Trainer() { Name = "Mpozas" };
            Trainer t2 = new Trainer() { Name = "Pasparakis" };
            Trainer t3 = new Trainer() { Name = "Sikarlis" };

            Janitor janitor = new Janitor() { Name = "Nerina" };

            c1.AttachRange(s1, s2, t1, janitor);
            c2.AttachRange(s1, s3, s4, t1, t2, t3, janitor); 
            c3.AttachRange(s1, s5, t1, janitor);
            m1.AttachRange(s1, s2, s3, s4, s5, t1, t2, t3, janitor);

            c1.AddAssignment(a1);
            c2.AddAssignment(a2);
            c3.AddAssignment(a3);
            c3.AddAssignment(a4);

            Console.WriteLine("========================----------------------");
            m1.AddAssignment(a1);
            m1.AddAssignment(a2);
            m1.AddAssignment(a3);
            m1.AddAssignment(a4);

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
}
