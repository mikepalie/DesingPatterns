using System;

namespace Composite.Structural
{
    /// <summary>
    /// Composite Design Pattern
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {


            Leaf obj1 = new Leaf("Turbox TV", 500);
            Leaf obj2 = new Leaf("Entos Sofa", 1600);
            Leaf obj3 = new Leaf("Pirounia", 40);
            Leaf obj4 = new Leaf("Trapezi", 160);

            Composite saloni = new Composite("Saloni");

            saloni.Add(obj1);
            saloni.Add(obj2);

            Composite trapezaria = new Composite("Trapezaria");
            trapezaria.Add(obj3);
            trapezaria.Add(obj4);

            saloni.Add(trapezaria);

            saloni.Display(0);

            



















            //Room saloni = new Room("Saloni");

            //Room kitchen = new Room("Kitchen");

            //Item psigieo = new Item("psigeio", 600);
            //Item sofa = new Item("sofa", 300);
            //Item TV = new Item("TV", 15000);
            //Item fournos = new Item("fournos", 1500);

            //saloni.Add(sofa);
            //saloni.Add(TV);
            //kitchen.Add(psigieo);
            //kitchen.Add(fournos);

            //var Totalsaloni = 0;
            //foreach (Item item  in saloni.children)
            //{
            //    Totalsaloni += item.Price;
            //}

            //var TotalKitchen = 0;
            //foreach (Item item in kitchen.children)
            //{
            //    TotalKitchen += item.Price;
            //}

            //Console.WriteLine($"Total cost of saloni : {Totalsaloni} and total cost of kitchen : {TotalKitchen}");


            Console.ReadKey();
        }
    }
}
