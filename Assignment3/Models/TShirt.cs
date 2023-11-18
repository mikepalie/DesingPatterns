using Assignment3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class TShirt
    {
        public Color Color;
        public Fabric Fabric;
        public Size Size;

        public TShirt(Color color, Fabric fabric, Size size)
        {
            Color = color;
            Fabric = fabric;
            Size = size;
        }

        public decimal Price { get; set; }

        
    }
}
