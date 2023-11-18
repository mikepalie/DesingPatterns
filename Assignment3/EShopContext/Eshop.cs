using Assignment3.Models;
using Assignment3.VariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.EShopContext
{
    public class Eshop
    {
        private IEnumerable<IVariationStrategy> variations;


        public void SetVariation(IEnumerable<IVariationStrategy> variationStrategies)
        {
            variations = variationStrategies;
        }

        public void PayTShirt(TShirt shirt)
        {
            foreach (var variation in variations)
            {
                variation.Cost(shirt);
            }

            Console.WriteLine($"T-Shirt final price is {shirt.Price} euros");
        }


    }
}
