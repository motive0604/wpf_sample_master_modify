// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;
using System.Windows.Controls;

namespace AddingEventHandler
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
        Button b2;
        Button b3;

        private void MakeButton(object sender, RoutedEventArgs e)
        {
            b2 = new Button {Content = "New Button"};
            // Associate event handler to the button. You can remove the event 
            // handler using "-=" syntax rather than "+=".
            b2.Click += Onb1Click;
            root.Children.Insert(root.Children.Count, b2);
            DockPanel.SetDock(b2, Dock.Top);
            text1.Text = "Now click the second button...";
            b1.IsEnabled = false;
        }
        private void Onb1Click(object sender, RoutedEventArgs e)
        {
            b3 = new Button { Content = "Last Button" };
            // Associate event handler to the button. You can remove the event 
            // handler using "-=" syntax rather than "+=".
            b3.Click += Onb2Click;
            root.Children.Insert(root.Children.Count, b3);
            DockPanel.SetDock(b3, Dock.Top);
            text1.Text = "Now click the second button...";
            b2.IsEnabled = false;
        }
        private void Onb2Click(object sender, RoutedEventArgs e)
        {
            text1.Text = "Last Button (b2) Was Clicked!!";
            b3.IsEnabled = false;
        }
    }
}