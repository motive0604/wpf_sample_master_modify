// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.ComponentModel;
using System.Globalization;

namespace BindingToMethod
{
    public class TemperatureScale : INotifyPropertyChanged
    {
        private TempType _type;

        public TemperatureScale()
        {
        }

        public TemperatureScale(TempType type)
        {
            _type = type;
        }

        public TempType Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ConvertTemp(double degree, TempType temptype)
        {
            Type = temptype;
            Console.WriteLine("ConvertTemp");
            Console.WriteLine(temptype);

            switch (temptype)
            {
                case TempType.In:
                    return (degree*0.4).ToString(CultureInfo.InvariantCulture) + " " + "In";
                case TempType.ft:
                    return (degree*0.03).ToString(CultureInfo.InvariantCulture) + " " + "ft";
            }
            return "Unknown Type";
        }

        protected void OnPropertyChanged(string name)
        {
            Console.WriteLine(name);

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}