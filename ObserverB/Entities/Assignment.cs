using System.Collections.Generic;

namespace ObserverB.Entities
{
    public class Assignment
    {
        public string Title { get; set; }
        public Course Course { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
