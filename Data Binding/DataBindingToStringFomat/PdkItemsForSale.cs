using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataBindingToStringFomat
{
    public class PdkItemForSale : ObservableCollection<PdkPurchaseItem>
    {
        public PdkItemForSale()
        {
            Add((new PdkPurchaseItem("PDK Snowboard and bindings", 120, new DateTime(2009, 1, 1))));
            Add((new PdkPurchaseItem("PDK Inside C#, second edition", 10, new DateTime(2009, 2, 2))));
            Add((new PdkPurchaseItem("PDK Laptop - only 1 year old", 499.99, new DateTime(2009, 2, 28))));
            Add((new PdkPurchaseItem("PDK Set of 6 chairs", 120, new DateTime(2009, 2, 28))));
            Add((new PdkPurchaseItem("PDK My DVD Collection", 15, new DateTime(2009, 1, 1))));
            Add((new PdkPurchaseItem("PDK TV Drama Series", 39.985, new DateTime(2009, 1, 1))));
            Add((new PdkPurchaseItem("PDK Squash racket", 60, new DateTime(2009, 2, 28))));
        }
    }
}
