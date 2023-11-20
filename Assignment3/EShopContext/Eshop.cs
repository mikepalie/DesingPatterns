using Assignment3.Models;
using Assignment3.PaymentMethodStrategy;
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
        private IPaymentMethodStrategy paymentMethod;

        public void SetPaymentMethod(IPaymentMethodStrategy method)
        {
            paymentMethod = method;
        }



        public void SetVariation(IEnumerable<IVariationStrategy> variationStrategies)
        {
            variations = variationStrategies;
        }

        public void CalculateCost(TShirt shirt)
        {
            foreach (var variation in variations)
            {
                variation.Cost(shirt);
            }

            Console.WriteLine($"T-Shirt final price is {shirt.Price} euros");
        }

        public void PayTShirt(decimal price)
        {
            

            if (paymentMethod.Pay(price))
            {
                Console.WriteLine("Transaction was ssuccessfull");
            }
            else
            {
                Console.WriteLine("Transaction aborted");
            }

        }

        public  void Dicount(TShirt shirt, decimal? percentage)
        {
            paymentMethod.Discount(shirt, percentage);
        }


    }
}
