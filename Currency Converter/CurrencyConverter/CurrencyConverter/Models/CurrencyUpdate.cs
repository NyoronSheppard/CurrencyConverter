using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    //Static Class for update the Currency Buttons
    public static class CurrencyUpdate
    {
        //Button 1 Currency
        public static string buttonCurrency1;
        public static string urlFlag1;
        public static string currencyName1;
        public static bool selected1;

        //Button 2 Currency
        public static string buttonCurrency2;
        public static string urlFlag2;
        public static string currencyName2;
        public static bool selected2;

        //Button 3 Currency 
        public static string buttonCurrency3;
        public static string urlFlag3;
        public static string currencyName3;
        public static bool selected3;

        //Button 4 Currency
        public static string buttonCurrency4;
        public static string urlFlag4;
        public static string currencyName4;
        public static bool selected4;

        //First Time (if is it the first time, put initial values)
        public static bool firstTime;

        public static void first()
        {
            buttonCurrency1 = "USD";
            urlFlag1 = "/Assets/flagUSD.png";
            currencyName1 = "United States Dollar";
            selected1 = false;

            buttonCurrency2 = "EUR";
            urlFlag2 = "/Assets/flagEUR.png";
            currencyName2 = "Euro";
            selected2 = false;

            buttonCurrency3 = "GBP";
            urlFlag3 = "/Assets/flagGBP.png";
            currencyName3 = "British Pound Sterling";
            selected3 = false;

            buttonCurrency4 = "JPY";
            urlFlag4 = "/Assets/flagJPY.png";
            currencyName4 = "Japanese Yen";
            selected4 = false;

            firstTime = true;   
        }
    }
}
