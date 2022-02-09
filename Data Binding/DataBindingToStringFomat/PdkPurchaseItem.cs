using System;

namespace DataBindingToStringFomat
{
    public class PdkPurchaseItem
    {
        public PdkPurchaseItem()
        {
        }

        public PdkPurchaseItem(string desc, double price, DateTime endDate)
        {
            Console.WriteLine(desc);
            Console.WriteLine(price);
            Console.WriteLine(endDate);

            PdkDescription = desc;
            PdkPrice = price;
            PdkOfferExpires = endDate;
        }

        public string PdkDescription { get; set; }
        public double PdkPrice { get; set; }
        public DateTime PdkOfferExpires { get; set; }

        public override string ToString() => $"{PdkDescription}, {PdkPrice:c}, {PdkOfferExpires:D}";
    }
}
