// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.ComponentModel;

namespace EditingCollections
{
    public class PurchaseItem : INotifyPropertyChanged, IEditableObject
    {
        private ItemData _copyData;
        private ItemData _currentData;

        public PurchaseItem()
            : this("New item", 0, DateTime.Now, "name")
        {
        }

        public PurchaseItem(string desc, double price, DateTime endDate, string PName)
        {
            Description = desc;
            Price = price;
            OfferExpires = endDate;
            Name = PName;

        }
        

        public string Description
        {
            get { return _currentData.Description; }
            set
            {
                if (_currentData.Description != value)
                {
                    _currentData.Description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        public double Price
        {
            get { return _currentData.Price; }
            set
            {
                if (_currentData.Price != value)
                {
                    _currentData.Price = value;
                    NotifyPropertyChanged("Price");
                }
            }
        }

        public DateTime OfferExpires
        {
            get { return _currentData.OfferExpires; }
            set
            {
                if (value != _currentData.OfferExpires)
                {
                    _currentData.OfferExpires = value;
                    NotifyPropertyChanged("OfferExpires");
                }
            }
        }
        public string Name
        {
            get { return _currentData.Name; }
            set
            {
                if(_currentData.Name != value)
                {
                    _currentData.Name = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        public override string ToString() => $"{Description}, {Price:c}, {OfferExpires:D},{Name}$";

        private struct ItemData
        {
            internal string Description;
            internal DateTime OfferExpires;
            internal double Price;
            internal string Name;
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        #endregion

        #region IEditableObject Members

        public void BeginEdit()
        {
            _copyData = _currentData;
        }

        public void CancelEdit()
        {
            _currentData = _copyData;
            NotifyPropertyChanged("");
        }

        public void EndEdit()
        {
            _copyData = new ItemData();
        }

        #endregion
    }
}