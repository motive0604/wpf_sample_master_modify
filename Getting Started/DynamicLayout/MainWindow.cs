// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;

namespace DynamicLayout
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
        int a = 0;

        private void HandleClick(object sender, RoutedEventArgs e)
        {
            if (a == 0) 
            {
                Button1.Content = "Hello World";
                a++;
            }
            else if (a == 1) 
            {
                Button1.Content = "Hallym";
                a++;
            }
            else if (a == 2)
            {
                Button1.Content = "Retry!";
                a--;
            }
        }
    }
}