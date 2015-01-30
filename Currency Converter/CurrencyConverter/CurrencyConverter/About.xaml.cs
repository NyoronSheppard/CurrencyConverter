using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

namespace CurrencyConverter
{
    public partial class About : PhoneApplicationPage
    {
        public About()
        {
            InitializeComponent();

            // Determine the visibility of the dark background.
            Visibility darkBackgroundVisibility =
                (Visibility)Application.Current.Resources["PhoneDarkThemeVisibility"];

            // Icon dark or light
            if (darkBackgroundVisibility == Visibility.Visible)
            {
                BitmapImage bm = new BitmapImage(new Uri(@"/Assets/dollar.png", UriKind.RelativeOrAbsolute));
                iconApp.Source = bm;
            }
            else
            {
                BitmapImage bm = new BitmapImage(new Uri(@"/Assets/dollarblack.png", UriKind.RelativeOrAbsolute));
                iconApp.Source = bm;
            }
        }

        //Go to MainPage
        private void onClickImage(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}