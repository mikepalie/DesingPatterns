using Assignment3.Enums;
using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.VariationStrategy
{
    public class SizeVariationNormalStrategy : IVariationStrategy
    {


        //Timokatalogos
        private static Dictionary<Size, decimal> sizeVariations;

        static SizeVariationNormalStrategy()
        {
            sizeVariations = new Dictionary<Size, decimal>()
                {
                    {Size.XS,2m },
                    {Size.S,3m },
                    {Size.M,4m },
                    {Size.L,5m },
                    {Size.XL,7m },
                    {Size.XXL,1m },
                };
        }




        public void Cost(TShirt Tshirt)             //new Tshirt(){}
        {
            Tshirt.Price += sizeVariations[Tshirt.Size];
        }

    }
    
}
