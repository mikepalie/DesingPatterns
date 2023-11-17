using ObserverB.AcademicObserverManager;
using System;
using System.Collections.Generic;

namespace ObserverB.Entities
{
    public class Trainer : IAcademic
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public string LastName { get; set; }

        public void Update(Assignment ass)
        {
            Console.WriteLine($"Trainer {Name}, the assignment {ass.Title} has been added!");
            Assignments.Add(ass);
        }
    }
}
