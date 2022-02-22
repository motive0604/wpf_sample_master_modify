// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;

namespace Paths
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

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            if (BB.FlowDirection == FlowDirection.RightToLeft)
                BB.FlowDirection = FlowDirection.LeftToRight;
            else
                BB.FlowDirection = FlowDirection.RightToLeft;
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            if (RR.FlowDirection == FlowDirection.RightToLeft)
                RR.FlowDirection = FlowDirection.LeftToRight;
            else
                RR.FlowDirection = FlowDirection.RightToLeft;

        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            if (GG.FlowDirection == FlowDirection.RightToLeft)
                GG.FlowDirection = FlowDirection.LeftToRight;
            else
                GG.FlowDirection = FlowDirection.RightToLeft;

        }
    }
}