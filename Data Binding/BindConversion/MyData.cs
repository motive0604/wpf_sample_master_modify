// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.ComponentModel;

namespace BindConversion
{
    public class MyData : INotifyPropertyChanged
    {
        private DateTime _thedate;

        public MyData()
        {
            _thedate = DateTime.Now;
        }

        public DateTime TheDate
        {
            get {
                Console.WriteLine("11");
                Console.WriteLine(_thedate);
                return _thedate; 
            }

            set
            {
                Console.WriteLine("22");
                _thedate = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TheDate"));


            }
        }

        // Declare event
        public event PropertyChangedEventHandler PropertyChanged;
        // OnPropertyChanged method to update property value in binding
        private void OnPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}