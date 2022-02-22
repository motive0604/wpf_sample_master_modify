// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;

namespace LTRRTL
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (a == 1)
            {
                LTR.FlowDirection = FlowDirection.RightToLeft;
                RTR.FlowDirection = FlowDirection.LeftToRight;
                a = 0;
            }
            else
            {
                LTR.FlowDirection = FlowDirection.LeftToRight;
                RTR.FlowDirection = FlowDirection.RightToLeft;
                a = 1;
            }
        }
    }
}