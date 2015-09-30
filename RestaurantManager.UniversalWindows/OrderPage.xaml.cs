using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RestaurantManager.UniversalWindows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderPage : Page
    {
        public OrderPage()
        {
            this.InitializeComponent();
        }


        // https://msdn.microsoft.com/sv-se/library/windows/apps/windows.ui.xaml.controls.appbar
        // Important  You should use the AppBar only when you are upgrading a 
        // Universal Windows 8 app that uses the AppBar, and need to minimize changes. 
        // For new apps in Windows 10, we recommend using the CommandBar control instead.

        /// <summary>
        /// **Add To Order** button pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddToOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// **Submit Order** button pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmitOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Home clicked on OrderPage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void appBarHomeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
