using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICard card = Goofy.SimpleFactory(Card.MasterCard);
            Console.WriteLine(  card.GetCardType()    );
            Console.WriteLine(  card.GetCreditLimit()  );
        }
    }

    enum Card
    {
        MasterCard,
        VisaCard,
        PaySafeCard
    }

    class Goofy
    {
        public static ICard SimpleFactory(Card choice)
        {
            switch (choice)
            {
                case Card.MasterCard: return new MasterCard();
                case Card.VisaCard: return new VisaCard();
                case Card.PaySafeCard: return new PaySafeCard();
                default: return null;
            }
        }
    }

    public interface ICard
    {
        string GetCardType();
        int GetCreditLimit();
    }

    public class MasterCard: ICard
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

    public class VisaCard: ICard
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

    public class PaySafeCard :ICard
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
