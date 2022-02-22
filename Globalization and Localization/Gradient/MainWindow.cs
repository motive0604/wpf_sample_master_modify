// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;
using System.Windows.Media;

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
            if (tool.Height == 50)
                tool.Height = 70;
            else
                tool.Height = 50;
        }
        int x = 0;

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (x == 1)
            {
                col1.Color = Colors.DarkRed;
                col2.Color = Colors.DarkBlue;
                x = 0;
            }
            else
            {
                col1.Color = Colors.Yellow;
                col2.Color = Colors.Lime;
                x = 1;
            }

        }
    }
}