using Assignment3.Enums;
using Assignment3.EShopContext;
using Assignment3.Models;
using Assignment3.VariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IVariationStrategy> ShopNormalVariations = new List<IVariationStrategy>()
            {
                new ColorVariationNormalStrategy(),
                new SizeVariationNormalStrategy(),
                new FabricVariationNormalStrategy()
            };


            TShirt shirt = new TShirt(Color.BLUE, Fabric.CASHMERE, Size.XS);

            var eshop = new Eshop();
            eshop.SetVariation(ShopNormalVariations);
            eshop.PayTShirt(shirt);
        }
    }
}
