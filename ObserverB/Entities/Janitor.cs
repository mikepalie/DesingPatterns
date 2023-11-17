using ObserverB.AcademicObserverManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverB.Entities
{
    public class Janitor : IAcademic
    {
        public List<Assignment> Assignments { get; set; }
        public List<Course> Courses { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public void Update(Assignment ass)
        {
            Console.WriteLine($"Janitor {Name} is looking assignment {ass.Title}");
        }
    }
}
