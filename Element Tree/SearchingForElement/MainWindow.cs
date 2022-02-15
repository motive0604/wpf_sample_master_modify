// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SearchingForElement
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

        private void Find(object sender, RoutedEventArgs e)
        {
            var wantedNode = stackPanel.FindName("dog");
            if (wantedNode is TextBlock)
            {
                // Following executed if Text element was found.
                var wantedChild = wantedNode as TextBlock;
                if (wantedChild.Foreground == Brushes.Red)
                    wantedChild.Foreground = Brushes.Black;
                else
                    wantedChild.Foreground = Brushes.Red;
            }

            var catNode = stackPanel.FindName("cat");
            if (catNode is TextBlock)
            {
                // Following executed if Text element was found.
                var wantedChild = catNode as TextBlock;
                if (wantedChild.Foreground == Brushes.Yellow)
                    wantedChild.Foreground = Brushes.Black;
                else
                    wantedChild.Foreground = Brushes.Yellow;
            }

            var fishNode = stackPanel.FindName("fish");
            if (fishNode is TextBlock)
            {
                // Following executed if Text element was found.
                var wantedChild = fishNode as TextBlock;
                if(wantedChild.Foreground == Brushes.Blue)
                    wantedChild.Foreground = Brushes.Black;
                else
                    wantedChild.Foreground = Brushes.Blue;
            }
        }
    }
}