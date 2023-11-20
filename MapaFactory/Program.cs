using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            string choice = "1";

            if(choice == "1")
            {
                MasterCard m = new MasterCard();
                m.GetCardType();
            }
            else if (choice == "2")
            {
                VisaCard v = new VisaCard();
                v.GetCardType();
            }
            else if (choice == "3")
            {
                PaySafeCard p = new PaySafeCard();
                p.GetCardType();
            }



        }
    }

    class MasterCard
    {
        public string GetCardType()
        {
            return "Master Card Credit Card";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }
    }

    class VisaCard
    {
        public string GetCardType()
        {
            return "Visa Card Credit Card";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }

    class PaySafeCard
    {
        public string GetCardType()
        {
            return "Paysafe Card Credit Card";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }
    }
}
