using System;
using System.Linq;
using System.Collections.Generic;

namespace Composite.Structural
{
    /// <summary>
    /// The 'Composite' class
    /// </summary>

    public class Composite : Component
    {
        public List<Component> children = new List<Component>();

        private int price;

        public override int Price
        {
            get { 
                
                
                return children.Sum(x=>x.Price);
            
            }
            protected set { price = value; }
        }


        // Constructor

        public Composite(string name): base(name)
        {
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " : " + Price);

            // Recursively display child nodes

            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
