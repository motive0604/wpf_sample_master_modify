// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Threading;

namespace BindConversion
{
    public class MyConverter : IValueConverter
    {
        public static CultureInfo cul;
        
        public object Convert(object o, Type type,
            object parameter, CultureInfo cul)
        {
            var date = (DateTime) o;
            Console.WriteLine(type.Name);
            switch (type.Name)
            {
                case "String":
                    return date.ToString("F",cul);
                case "Brush":
                    return Brushes.Red;
                default:
                    return o;
            }
        }

        public object ConvertBack(object o, Type type,
            object parameter, CultureInfo culture) => null;
    }
}
