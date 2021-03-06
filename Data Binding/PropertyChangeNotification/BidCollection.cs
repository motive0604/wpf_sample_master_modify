// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.ObjectModel;
using System.Timers;

namespace PropertyChangeNotification
{
    public class BidCollection : ObservableCollection<Bid>
    {
        private static Bid _item1 = new Bid("Perseus Vase", (decimal) 24.95);
        private static Bid _item2 = new Bid("Hercules Statue", (decimal) 16.05);
        private static Bid _item3 = new Bid("Odysseus Painting", (decimal) 100.0);
        private static Bid _item4 = new Bid("Hallym University", (decimal)50.0);

        public BidCollection()
        {
            Add(_item1);
            Add(_item2);
            Add(_item3);
            Add(_item4);
            //CreateTimer();
        }

        /*private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            _item1.BidItemPrice += (decimal) 1.25;
            _item2.BidItemPrice += (decimal) 2.45;
            _item3.BidItemPrice += (decimal) 10.55;
            _item4.BidItemPrice += (decimal)5.15;
        }*/
        public static void adds()
        {
            _item1.BidItemPrice += (decimal)1.25;
            _item2.BidItemPrice += (decimal)2.45;
            _item3.BidItemPrice += (decimal)10.55;
            _item4.BidItemPrice += (decimal)5.15;
        }

        /*private void CreateTimer()
        {
            var timer1 = new Timer
            {
                Enabled = true,
                Interval = 2000
            };
            timer1.Elapsed += Timer1_Elapsed;
        }*/
    }
}