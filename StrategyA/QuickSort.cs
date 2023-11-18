using System;
using System.Collections.Generic;

namespace Strategy.RealWorld
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>

    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();  // Default is Quicksort
            Console.WriteLine("QuickSorted list ");
        }
    }
}
