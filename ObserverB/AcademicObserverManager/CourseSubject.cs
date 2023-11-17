using ObserverB.Entities;
using System.Collections.Generic;

namespace ObserverB.AcademicObserverManager
{
    public abstract class CourseSubject
    {
        public string Name { get; set; }
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<IAcademic> Academics { get; set; } = new List<IAcademic>();//Observers

        public CourseSubject(string name)
        {
            Name = name;
        }

        public void Attach(IAcademic academic)
        {
            Academics.Add(academic);
        }

        public void AttachRange(params IAcademic[] academics)
        {
            foreach (IAcademic academic in academics)
            {
                Academics.Add(academic);
            }
        }

        public void Detach(IAcademic academic)
        {
            Academics.Remove(academic);
        }

        public void DetachAll()
        {
            Academics.Clear();
        }

        public void Notify(Assignment ass)
        {
            //Console.WriteLine($"Notifying.....{ass.Title}");
            foreach (IAcademic aca in Academics)
            {
                aca.Update(ass);
            }
        }

        public void AddAssignment(Assignment ass)
        {
            Assignments.Add(ass);
            Notify(ass);
        }


    }
}
