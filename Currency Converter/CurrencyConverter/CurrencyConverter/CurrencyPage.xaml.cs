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
    public partial class CurrencyPage : PhoneApplicationPage
    {
        private static bool isCreated = false;
        public CurrencyPage()
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

            if (Models.CurrencyUpdate.firstTime == false)
            {
                Models.CurrencyUpdate.first();
            }

            if (isCreated == false)
            {
                CurrencyBoxList.ItemsSource = CurrencyList.GetCurrencyStart();
                isCreated = true;
            }
            else
            {
                CurrencyBoxList.ItemsSource = CurrencyList.GetCurrency();
            }
        }

        //Currency Class
        public class Currency
        {
            public string ID { get; set; }
            public string nameCurrency { get; set; }
            public string completeNameCurrency { get; set; }
            public string urlCurrency { get; set; }
            public bool selected { get; set; }
        }

        //Create a Currency List
        public static class CurrencyList
        {
            public static List<Currency> currencys = new List<Currency>();
            public static List<Currency> GetCurrencyStart()
            {
                currencys.Add(new Currency
                {
                    ID = "0",
                    nameCurrency = "USD",
                    completeNameCurrency = "United States Dollar",
                    urlCurrency = "/Assets/flagUSD.png",
                    selected = false
                });

                currencys.Add(new Currency
                {
                    ID = "1",
                    nameCurrency = "EUR",
                    completeNameCurrency = "Euro",
                    urlCurrency = "/Assets/flagEUR.png",
                    selected = false
                });

                currencys.Add(new Currency
                {
                    ID = "2",
                    nameCurrency = "GBP",
                    completeNameCurrency = "British Pound Sterling",
                    urlCurrency = "/Assets/flagGBP.png",
                    selected = false
                });

                currencys.Add(new Currency
                {
                    ID = "3",
                    nameCurrency = "CAD",
                    completeNameCurrency = "Canadian Dollar",
                    urlCurrency = "/Assets/flagCAD.png",
                    selected = false
                });

                currencys.Add(new Currency
                {
                    ID = "4",
                    nameCurrency = "BRL",
                    completeNameCurrency = "Brazilian Real",
                    urlCurrency = "/Assets/flagBRL.png",
                    selected = false
                });

                currencys.Add(new Currency
                {
                    ID = "5",
                    nameCurrency = "CNY",
                    completeNameCurrency = "Chinese Yuan",
                    urlCurrency = "/Assets/flagCNY.png",
                    selected = false
                });

                currencys.Add(new Currency
                {
                    ID = "6",
                    nameCurrency = "HKD",
                    completeNameCurrency = "Hong Kong Dollar",
                    urlCurrency = "/Assets/flagHKD.png",
                    selected = false
                });

                currencys.Add(new Currency
                {
                    ID = "7",
                    nameCurrency = "JPY",
                    completeNameCurrency = "Japanese Yen",
                    urlCurrency = "/Assets/flagJPY.png",
                    selected = false
                });

                currencys.Add(new Currency
                {
                    ID = "8",
                    nameCurrency = "MXN",
                    completeNameCurrency = "Mexican Peso",
                    urlCurrency = "/Assets/flagMXN.png",
                    selected = false
                });

                currencys.Add(new Currency
                {
                    ID = "9",
                    nameCurrency = "NZD",
                    completeNameCurrency = "New Zealand Dollar",
                    urlCurrency = "/Assets/flagNZD.png",
                    selected = false
                });

                currencys.Add(new Currency
                {
                    ID = "10",
                    nameCurrency = "NOK",
                    completeNameCurrency = "Norwegian Krone",
                    urlCurrency = "/Assets/flagNOK.png",
                    selected = false
                });

                currencys.Add(new Currency
                {
                    ID = "11",
                    nameCurrency = "RUB",
                    completeNameCurrency = "Russian Ruble",
                    urlCurrency = "/Assets/flagRUB.png",
                    selected = false
                });

                currencys.Add(new Currency
                {
                    ID = "12",
                    nameCurrency = "SEK",
                    completeNameCurrency = "Swedish Krona",
                    urlCurrency = "/Assets/flagSEK.png",
                    selected = false
                });

                //New Currencys
                currencys.Add(new Currency
                {
                    ID = "13",
                    nameCurrency = "CHF",
                    completeNameCurrency = "Swiss Franc",
                    urlCurrency = "/Assets/flagCHF.png",
                    selected = false
                });

                currencys.Add(new Currency
                {
                        ID = "14",
                        nameCurrency = "BGN",
                        completeNameCurrency = "Bulgarian Lev",
                        urlCurrency = "/Assets/flagBGN.png",
                        selected = false
                });

                currencys.Add(new Currency
                {
                        ID = "15",
                        nameCurrency = "CZK",
                        completeNameCurrency = "Czech Koruna",
                        urlCurrency = "/Assets/flagCZK.png",
                        selected = false
                });

                currencys.Add(new Currency
                {
                        ID = "16",
                        nameCurrency = "DKK",
                        completeNameCurrency = "Danish Krone",
                        urlCurrency = "/Assets/flagDKK.png",
                        selected = false
                });

                currencys.Add(new Currency
                {
                        ID = "17",
                        nameCurrency = "HRK",
                        completeNameCurrency = "Croatian Kuna",
                        urlCurrency = "/Assets/flagHRK.png",
                        selected = false
                });

                currencys.Add(new Currency
                {
                        ID = "18",
                        nameCurrency = "HUF",
                        completeNameCurrency = "Hungarian Forint",
                        urlCurrency = "/Assets/flagHUF.png",
                        selected = false
                });

                currencys.Add(new Currency
                {
                        ID = "19",
                        nameCurrency = "IDR",
                        completeNameCurrency = "Indonesian Rupiah",
                        urlCurrency = "/Assets/flagIDR.png",
                        selected = false
                });

                currencys.Add(new Currency
                {
                        ID = "20",
                        nameCurrency = "INR",
                        completeNameCurrency = "Indian Rupee",
                        urlCurrency = "/Assets/flagINR.png",
                        selected = false
                });

                currencys.Add(new Currency
                {
                        ID = "21",
                        nameCurrency = "KRW",
                        completeNameCurrency = "South Korean Won",
                        urlCurrency = "/Assets/flagKRW.png",
                        selected = false
                });

                currencys.Add(new Currency
                {
                        ID = "22",
                        nameCurrency = "LTL",
                        completeNameCurrency = "Lithuanian Litas",
                        urlCurrency = "/Assets/flagLTL.png",
                        selected = false
                });

                currencys.Add(new Currency
                {
                        ID = "23",
                        nameCurrency = "PLN",
                        completeNameCurrency = "Polish Zloty",
                        urlCurrency = "/Assets/flagPLN.png",
                        selected = false
                });

                currencys.Add(new Currency
                {
                        ID = "24",
                        nameCurrency = "RON",
                        completeNameCurrency = "New Romanian Leu",
                        urlCurrency = "/Assets/flagRON.png",
                        selected = false
                });

                return currencys;
            }

            public static List<Currency> GetCurrency()
            {
                return currencys;
            }
        }

        private void CurrencyBoxList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CurrencyBoxList.SelectedItem == null)
            {   //Nothing happens
                return;
            }

            CurrencyList.currencys[CurrencyBoxList.SelectedIndex].selected = true;

            Currency currentCurrency = (Currency)CurrencyBoxList.SelectedItem;

            //Currency 1
            if (Models.CurrencyUpdate.selected1 == true)
            {
                Models.CurrencyUpdate.buttonCurrency1 = currentCurrency.nameCurrency;
                Models.CurrencyUpdate.urlFlag1 = currentCurrency.urlCurrency;
                Models.CurrencyUpdate.currencyName1 = currentCurrency.completeNameCurrency;
            }

            Models.CurrencyUpdate.selected1 = false;

            //Currency 2
            if (Models.CurrencyUpdate.selected2 == true)
            {
                Models.CurrencyUpdate.buttonCurrency2 = currentCurrency.nameCurrency;
                Models.CurrencyUpdate.urlFlag2 = currentCurrency.urlCurrency;
                Models.CurrencyUpdate.currencyName2 = currentCurrency.completeNameCurrency;
            }

            Models.CurrencyUpdate.selected2 = false;

            //Currency 3
            if (Models.CurrencyUpdate.selected3 == true)
            {
                Models.CurrencyUpdate.buttonCurrency3 = currentCurrency.nameCurrency;
                Models.CurrencyUpdate.urlFlag3 = currentCurrency.urlCurrency;
                Models.CurrencyUpdate.currencyName3 = currentCurrency.completeNameCurrency;
            }

            Models.CurrencyUpdate.selected3 = false;

            //Currency 4
            if (Models.CurrencyUpdate.selected4 == true)
            {
                Models.CurrencyUpdate.buttonCurrency4 = currentCurrency.nameCurrency;
                Models.CurrencyUpdate.urlFlag4 = currentCurrency.urlCurrency;
                Models.CurrencyUpdate.currencyName4 = currentCurrency.completeNameCurrency;
            }

            Models.CurrencyUpdate.selected4 = false;

            CurrencyList.currencys[CurrencyBoxList.SelectedIndex].selected = true;

            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        //Go to main page
        private void iconApp_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}