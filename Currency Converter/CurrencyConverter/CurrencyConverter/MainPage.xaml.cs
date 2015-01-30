using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using CurrencyConverter.Resources;
using System.Windows.Media.Imaging;
using System.Globalization;

using CurrencyConverter.Models;


namespace CurrencyConverter
{
    public partial class MainPage : PhoneApplicationPage
    {
        //Attributes
        string parseCurrency1 = "";
        string parseCurrency2 = "";
        string parseCurrency3 = "";
        string parseCurrency4 = "";

        USDToOtherCurrency otherCurrencyOffline;
        OtherCurrencyToUSD otherUSDOffline;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            otherCurrencyOffline = new USDToOtherCurrency();
            otherUSDOffline = new OtherCurrencyToUSD();

            // Determine the visibility of the dark background.
            Visibility darkBackgroundVisibility =
                (Visibility)Application.Current.Resources["PhoneDarkThemeVisibility"];

            // Icon dark or light
            if (darkBackgroundVisibility == Visibility.Visible)
            {
                BitmapImage bm = new BitmapImage(new Uri(@"/Assets/dollar.png", UriKind.RelativeOrAbsolute));
                iconApp.Source = bm;

                BitmapImage arrow = new BitmapImage(new Uri(@"/Assets/Images/next.png", UriKind.RelativeOrAbsolute));
                Arrow1.Source = arrow;
                Arrow2.Source = arrow;
                Arrow3.Source = arrow;
                Arrow4.Source = arrow;
            }
            else
            {
                BitmapImage bm = new BitmapImage(new Uri(@"/Assets/dollarblack.png", UriKind.RelativeOrAbsolute));
                iconApp.Source = bm;

                BitmapImage arrowBlack = new BitmapImage(new Uri(@"/Assets/Images/nextBlack.png", UriKind.RelativeOrAbsolute));
                Arrow1.Source = arrowBlack;
                Arrow2.Source = arrowBlack;
                Arrow3.Source = arrowBlack;
                Arrow4.Source = arrowBlack;
            }

            //Initial 4 Currencys
            if (Models.CurrencyUpdate.firstTime == false)
            {
                Models.CurrencyUpdate.first();
            }
            

            updateView();
            

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        //Change Currency1
        private void UpdateUSD_Click(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string textCurrency1 = TextBoxCurrency1.Text;

            parseCurrency1 = textCurrency1;

            if (textCurrency1.Contains(','))
            {
                textCurrency1 = textCurrency1.Replace(',', '.');
                textCurrency1 = textCurrency1 + "0";
                parseCurrency1 = textCurrency1; 
            }

            //Currency 1 - Currency 2
            Models.CurrencyConverter currency2 = new Models.CurrencyConverter(Models.CurrencyUpdate.buttonCurrency1, textCurrency1, Models.CurrencyUpdate.buttonCurrency2);

            //Currency 1 - Currency 3
            Models.CurrencyConverter currency3 = new Models.CurrencyConverter(Models.CurrencyUpdate.buttonCurrency1, textCurrency1, Models.CurrencyUpdate.buttonCurrency3);

            //Currency 1 - Currency 4
            Models.CurrencyConverter currency4 = new Models.CurrencyConverter(Models.CurrencyUpdate.buttonCurrency1, textCurrency1, Models.CurrencyUpdate.buttonCurrency4);

            //Wait por Sleep(x) seconds
            System.Threading.ThreadPool.QueueUserWorkItem(obj =>
            {
                System.Threading.Thread.Sleep(2500);

                Dispatcher.BeginInvoke(() =>
                {
                    try
                    {
                        //Error
                        if (currency2.currency == "Error" || currency3.currency == "Error" || currency4.currency == "Error")
                        {
                            offlineCurrency1();
                        }
                        else
                        {
                            TextBoxCurrency2.Text = currency2.currency;
                            TextBoxCurrency3.Text = currency3.currency;
                            TextBoxCurrency4.Text = currency4.currency;
                        }
                    }
                    catch
                    {
                        //TextBoxEUR.Text = "";
                        //TextBoxGBP.Text = "";

                        try
                        {
                            offlineCurrency1();
                        }
                        catch
                        {

                        }
                    }
                });
            });
        }

        //Change Currency2
        private void UpdateEUR_Click(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string textCurrency2 = TextBoxCurrency2.Text;

            parseCurrency2 = textCurrency2;

            if (textCurrency2.Contains(','))
            {
                textCurrency2 = textCurrency2.Replace(',', '.');
                textCurrency2 = textCurrency2 + "0";
                parseCurrency2 = textCurrency2;
            }

            //Currency 2 - Currency 1
            Models.CurrencyConverter currency1 = new Models.CurrencyConverter(Models.CurrencyUpdate.buttonCurrency2, textCurrency2, Models.CurrencyUpdate.buttonCurrency1);

            //Currency 2 - Currency 3
            Models.CurrencyConverter currency3 = new Models.CurrencyConverter(Models.CurrencyUpdate.buttonCurrency2, textCurrency2, Models.CurrencyUpdate.buttonCurrency3);

            //Currency 2 - Currency 4
            Models.CurrencyConverter currency4 = new Models.CurrencyConverter(Models.CurrencyUpdate.buttonCurrency2, textCurrency2, Models.CurrencyUpdate.buttonCurrency4);

            //Wait por Sleep(x) seconds
            System.Threading.ThreadPool.QueueUserWorkItem(obj =>
            {
                System.Threading.Thread.Sleep(2500);

                Dispatcher.BeginInvoke(() =>
                {
                    try
                    {
                        //Error
                        if (currency1.currency == "Error" || currency3.currency == "Error" || currency4.currency == "Error")
                        {
                            offlineCurrency2();
                        }
                        else
                        {
                            TextBoxCurrency1.Text = currency1.currency;
                            TextBoxCurrency3.Text = currency3.currency;
                            TextBoxCurrency4.Text = currency4.currency;
                        }
                    }
                    catch
                    {
                        //TextBoxUSD.Text = "";
                        //TextBoxGBP.Text = "";

                        try
                        {
                            offlineCurrency2();
                        }
                        catch
                        {

                        }
                    }

                });
            });
        }

        //Change Currency3
        private void UpdateGBP_Click(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string textCurrency3 = TextBoxCurrency3.Text;
            parseCurrency3 = textCurrency3;

            if (textCurrency3.Contains(','))
            {
                textCurrency3 = textCurrency3.Replace(',', '.');
                textCurrency3 = textCurrency3 + "0";
                parseCurrency3 = textCurrency3;
            }

            //Currency 3 - Currency 1
            Models.CurrencyConverter currency1 = new Models.CurrencyConverter(Models.CurrencyUpdate.buttonCurrency3, textCurrency3, Models.CurrencyUpdate.buttonCurrency1);

            //Currency 3 - Currency 2
            Models.CurrencyConverter currency2 = new Models.CurrencyConverter(Models.CurrencyUpdate.buttonCurrency3, textCurrency3, Models.CurrencyUpdate.buttonCurrency2);

            //Currency 3 - Currency 4
            Models.CurrencyConverter currency4 = new Models.CurrencyConverter(Models.CurrencyUpdate.buttonCurrency3, textCurrency3, Models.CurrencyUpdate.buttonCurrency4);

            //Wait por Sleep(x) seconds
            System.Threading.ThreadPool.QueueUserWorkItem(obj =>
            {
                System.Threading.Thread.Sleep(2500);

                Dispatcher.BeginInvoke(() =>
                {
                    try
                    {
                        //Error
                        if (currency1.currency == "Error" || currency2.currency == "Error" || currency4.currency == "Error")
                        {
                            offlineCurrency3();
                        }
                        else
                        {
                            TextBoxCurrency1.Text = currency1.currency;
                            TextBoxCurrency2.Text = currency2.currency;
                            TextBoxCurrency4.Text = currency4.currency;
                        }
                    }
                    catch
                    {
                        //TextBoxUSD.Text = "";
                        //TextBoxGBP.Text = "";

                        try
                        {
                            offlineCurrency3();
                        }
                        catch
                        {

                        }
                    }
                });
            });
        }

        //Change Currency4
        private void flagCurrency4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string textCurrency4 = TextBoxCurrency4.Text;
            parseCurrency4 = textCurrency4;

            if (textCurrency4.Contains(','))
            {
                textCurrency4 = textCurrency4.Replace(',', '.');
                textCurrency4 = textCurrency4 + "0";
                parseCurrency4 = textCurrency4;
            }

            //Currency 4 - Currency 1
            Models.CurrencyConverter currency1 = new Models.CurrencyConverter(Models.CurrencyUpdate.buttonCurrency4, textCurrency4, Models.CurrencyUpdate.buttonCurrency1);

            //Currency 4 - Currency 2
            Models.CurrencyConverter currency2 = new Models.CurrencyConverter(Models.CurrencyUpdate.buttonCurrency4, textCurrency4, Models.CurrencyUpdate.buttonCurrency2);

            //Currency 4 - Currency 3
            Models.CurrencyConverter currency3 = new Models.CurrencyConverter(Models.CurrencyUpdate.buttonCurrency4, textCurrency4, Models.CurrencyUpdate.buttonCurrency3);

            //Wait por Sleep(x) seconds
            System.Threading.ThreadPool.QueueUserWorkItem(obj =>
            {
                System.Threading.Thread.Sleep(2500);

                Dispatcher.BeginInvoke(() =>
                {
                    try
                    {
                        //Error
                        if (currency1.currency == "Error" || currency2.currency == "Error" || currency3.currency == "Error")
                        {
                            offlineCurrency4();
                        }
                        else
                        {
                            TextBoxCurrency1.Text = currency1.currency;
                            TextBoxCurrency2.Text = currency2.currency;
                            TextBoxCurrency3.Text = currency3.currency;
                        }
                    }
                    catch
                    {
                        //TextBoxUSD.Text = "";
                        //TextBoxGBP.Text = "";

                        try
                        {
                            offlineCurrency4();
                        }
                        catch
                        {

                        }
                    }
                });
            });
        }

        //Reset Text
        private void TextBoxUSD_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            TextBoxCurrency1.Text = "";
            TextBoxCurrency2.Text = "";
            TextBoxCurrency3.Text = "";
            TextBoxCurrency4.Text = "";
        }

        //Reset Text
        private void TextBoxEUR_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            TextBoxCurrency1.Text = "";
            TextBoxCurrency2.Text = "";
            TextBoxCurrency3.Text = "";
            TextBoxCurrency4.Text = "";
        }

        //Reset Text
        private void TextBoxGBP_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            TextBoxCurrency1.Text = "";
            TextBoxCurrency2.Text = "";
            TextBoxCurrency3.Text = "";
            TextBoxCurrency4.Text = "";
        }

        //Reset Text
        private void TextBoxCurrency4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            TextBoxCurrency1.Text = "";
            TextBoxCurrency2.Text = "";
            TextBoxCurrency3.Text = "";
            TextBoxCurrency4.Text = "";
        }


        //Update View
        public void updateView()
        {
            //Currency1
            LabelCurrency1.Text = Models.CurrencyUpdate.buttonCurrency1;
            textBlockCurrencyName1.Text = Models.CurrencyUpdate.currencyName1;

            BitmapImage bm1 = new BitmapImage(new Uri(@Models.CurrencyUpdate.urlFlag1, UriKind.RelativeOrAbsolute));
            flagCurrency1.Source = bm1;

            //Currency2
            LabelCurrency2.Text = Models.CurrencyUpdate.buttonCurrency2;
            textBlockCurrencyName2.Text = Models.CurrencyUpdate.currencyName2;

            BitmapImage bm2 = new BitmapImage(new Uri(@Models.CurrencyUpdate.urlFlag2, UriKind.RelativeOrAbsolute));
            flagCurrency2.Source = bm2;

            //Currency3
            LabelCurrency3.Text = Models.CurrencyUpdate.buttonCurrency3;
            textBlockCurrencyName3.Text = Models.CurrencyUpdate.currencyName3;

            BitmapImage bm3 = new BitmapImage(new Uri(@Models.CurrencyUpdate.urlFlag3, UriKind.RelativeOrAbsolute));
            flagCurrency3.Source = bm3;

            //Currency4
            LabelCurrency4.Text = Models.CurrencyUpdate.buttonCurrency4;
            textBlockCurrencyName4.Text = Models.CurrencyUpdate.currencyName4;

            BitmapImage bm4 = new BitmapImage(new Uri(@Models.CurrencyUpdate.urlFlag4, UriKind.RelativeOrAbsolute));
            flagCurrency4.Source = bm4;
        }

        //Offline Mode Currency 1
        public void offlineCurrency1()
        {
            //Error Currency 1 to Currency 2 and Currency 3 and Currency 4
            float parseCurrency2 = 0;
            float parseCurrency3 = 0;
            float parseCurrency4 = 0;

            //Change Currency 1 to USD
            float auxCurrency1 = float.Parse(parseCurrency1, CultureInfo.InvariantCulture);

            //1 Currency = x Dollars (1 EUR = 1.2 USD)
            float currencyXDollars = otherCurrencyOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency1);

            //X Currency * X Dollars (10 EUR = 12 USD)
            float currencyInDollars = auxCurrency1 * currencyXDollars;

            //1 Dollar = X Currency 2 (1 USD = 0.6 GBP) 
            float currency2XDollars =  otherUSDOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency2);

            //1 Dollar = X Currency 3 (1 USD = X Currency)
            float currency3XDollars = otherUSDOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency3);

            //1 Dollar = X Currency 4 (1 USD = X Currency)
            float currency4XDollars = otherUSDOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency4);

            //USD * Currency 2 and Currency 3 and Currency 4
            parseCurrency2 = currencyInDollars * currency2XDollars;
            parseCurrency3 = currencyInDollars * currency3XDollars;
            parseCurrency4 = currencyInDollars * currency4XDollars;

            TextBoxCurrency2.Text = parseCurrency2.ToString();
            TextBoxCurrency3.Text = parseCurrency3.ToString();
            TextBoxCurrency4.Text = parseCurrency4.ToString();
            
        }

        //Offline Mode Currency 2
        public void offlineCurrency2()
        {
            //Error Currency 2 to Currency 1 and Currency 3 and Currency 4
            float parseCurrency1 = 0;
            float parseCurrency3 = 0;
            float parseCurrency4 = 0;

            //Change Currency 2 to USD
            float auxCurrency2 = float.Parse(parseCurrency2, CultureInfo.InvariantCulture);

            //2 Currency = x Dollars (1 EUR = 1.2 USD)
            float currencyXDollars = otherCurrencyOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency2);

            //X Currency * X Dollars (10 EUR = 12 USD)
            float currencyInDollars = auxCurrency2 * currencyXDollars;

            //1 Dollar = X Currency 1 (1 USD = 0.6 GBP) 
            float currency1XDollars = otherUSDOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency1);

            //1 Dollar = X Currency 3 (1 USD = X Currency)
            float currency3XDollars = otherUSDOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency3);

            //1 Dollar = X Currency 4 (1 USD = X Currency)
            float currency4XDollars = otherUSDOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency4);

            //USD * Currency 2 and Currency 3 and Currency 4
            parseCurrency1 = currencyInDollars * currency1XDollars;
            parseCurrency3 = currencyInDollars * currency3XDollars;
            parseCurrency4 = currencyInDollars * currency4XDollars;

            TextBoxCurrency1.Text = parseCurrency1.ToString();
            TextBoxCurrency3.Text = parseCurrency3.ToString();
            TextBoxCurrency4.Text = parseCurrency4.ToString();
        }

        //Offline Mode Currency 3
        public void offlineCurrency3()
        {

            //Error Currency 3 to Currency 1 and Currency 2 and Currency 4
            float parseCurrency1 = 0;
            float parseCurrency2 = 0;
            float parseCurrency4 = 0;

            //Change Currency 3 to USD
            float auxCurrency3 = float.Parse(parseCurrency3, CultureInfo.InvariantCulture);

            //1 Currency = x Dollars (1 EUR = 1.2 USD)
            float currencyXDollars = otherCurrencyOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency3);

            //X Currency * X Dollars (10 EUR = 12 USD)
            float currencyInDollars = auxCurrency3 * currencyXDollars;

            //1 Dollar = X Currency 1 (1 USD = 0.6 GBP) 
            float currency1XDollars = otherUSDOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency1);

            //1 Dollar = X Currency 2 (1 USD = X Currency)
            float currency2XDollars = otherUSDOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency2);

            //1 Dollar = X Currency 4 (1 USD = X Currency)
            float currency4XDollars = otherUSDOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency4);

            //USD * Currency 1 and Currency 2 and Currency 4
            parseCurrency1 = currencyInDollars * currency1XDollars;
            parseCurrency2 = currencyInDollars * currency2XDollars;
            parseCurrency4 = currencyInDollars * currency4XDollars;

            TextBoxCurrency1.Text = parseCurrency1.ToString();
            TextBoxCurrency2.Text = parseCurrency2.ToString();
            TextBoxCurrency4.Text = parseCurrency4.ToString();
        }

        //Offline Mode Currency 4
        public void offlineCurrency4()
        {

            //Error Currency 4 to Currency 1 and Currency 2 and Currency 3
            float parseCurrency1 = 0;
            float parseCurrency2 = 0;
            float parseCurrency3 = 0;

            //Change Currency 3 to USD
            float auxCurrency4 = float.Parse(parseCurrency4, CultureInfo.InvariantCulture);

            //1 Currency = x Dollars (1 EUR = 1.2 USD)
            float currencyXDollars = otherCurrencyOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency4);

            //X Currency * X Dollars (10 EUR = 12 USD)
            float currencyInDollars = auxCurrency4 * currencyXDollars;

            //1 Dollar = X Currency 1 (1 USD = 0.6 GBP) 
            float currency1XDollars = otherUSDOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency1);

            //1 Dollar = X Currency 2 (1 USD = X Currency)
            float currency2XDollars = otherUSDOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency2);

            //1 Dollar = X Currency 3 (1 USD = X Currency)
            float currency3XDollars = otherUSDOffline.getCurrency(Models.CurrencyUpdate.buttonCurrency3);

            //USD * Currency 1 and Currency 2 and Currency 3
            parseCurrency1 = currencyInDollars * currency1XDollars;
            parseCurrency2 = currencyInDollars * currency2XDollars;
            parseCurrency3 = currencyInDollars * currency3XDollars;

            TextBoxCurrency1.Text = parseCurrency1.ToString();
            TextBoxCurrency2.Text = parseCurrency2.ToString();
            TextBoxCurrency3.Text = parseCurrency3.ToString();
        }

        //Go to about page
        private void onClickAbout(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        //Tap currency 1
        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Models.CurrencyUpdate.selected1 = true;

            NavigationService.Navigate(new Uri("/CurrencyPage.xaml", UriKind.Relative));
        }

        //Tap currency 2
        private void Image_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Models.CurrencyUpdate.selected2 = true;

            NavigationService.Navigate(new Uri("/CurrencyPage.xaml", UriKind.Relative));
        }

        //Tap currency 3
        private void Image_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Models.CurrencyUpdate.selected3 = true;

            NavigationService.Navigate(new Uri("/CurrencyPage.xaml", UriKind.Relative));
        }

        //Tap currency 4
        private void Arrow4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Models.CurrencyUpdate.selected4 = true;

            NavigationService.Navigate(new Uri("/CurrencyPage.xaml", UriKind.Relative));
        }




        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}