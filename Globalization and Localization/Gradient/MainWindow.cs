// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;

namespace Gradient
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
            if (tool.FlowDirection == FlowDirection.RightToLeft)
                tool.FlowDirection = FlowDirection.LeftToRight;
            else
                tool.FlowDirection = FlowDirection.RightToLeft;
      
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
         
        }
    }
}