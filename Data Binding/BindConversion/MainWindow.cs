// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Globalization;
using System.Threading;

namespace BindConversion
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
  

        public MainWindow()
        {
            InitializeComponent();
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            CultureInfo a = new CultureInfo("ko-KR");
            MyConverter.cul = a;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            CultureInfo a = new CultureInfo("en-US");
            MyConverter.cul = a;
        }
    }
}