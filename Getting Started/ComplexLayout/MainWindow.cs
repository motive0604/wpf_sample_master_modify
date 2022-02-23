// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;
using System.Windows.Media;

namespace ComplexLayout
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            LV.Background = Brushes.Aqua;
        }
        int a = 0;
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (a == 0)
            {
                LG.Text += "-By Hallym";
                a++;
            }
        }
    }
}