// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.ObjectModel;

namespace EditingCollections
{
    public class ItemsForSale : ObservableCollection<PurchaseItem>
    {
        public ItemsForSale()
        {
            Add((new PurchaseItem("Snowboard and bindings", 120, new DateTime(2009, 1, 1),"smith")));
            Add((new PurchaseItem("Inside C#, second edition", 10, new DateTime(2009, 2, 2),"AHM")));
            Add((new PurchaseItem("Laptop - only 1 year old", 499.99, new DateTime(2009, 2, 28),"KWH")));
            Add((new PurchaseItem("Set of 6 chairs", 120, new DateTime(2009, 2, 28),"KSH")));
            Add((new PurchaseItem("My DVD Collection", 15, new DateTime(2009, 1, 1),"MJH")));
            Add((new PurchaseItem("TV Drama Series", 39.985, new DateTime(2009, 1, 1),"KYB")));
            Add((new PurchaseItem("Squash racket", 60, new DateTime(2009, 2, 28),"KHY")));
        }
    }
}