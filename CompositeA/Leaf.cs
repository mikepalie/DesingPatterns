using System;

namespace Composite.Structural
{
    /// <summary>
    /// The 'Leaf' class
    /// </summary>

    public class Leaf : Component
    {
        // Constructor
        public override int Price { get; protected set; }
        public Leaf(string name, int price): base(name)
        {
            Price = price;
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " : " + Price);
        }
    }
}
