using ObserverB.Entities;
using System.Collections.Generic;

namespace ObserverB.AcademicObserverManager
{
    public interface IAcademic
    {
        void Update(Assignment ass);
        List<Assignment> Assignments { get; set; }
        List<Course> Courses { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
    }
}
