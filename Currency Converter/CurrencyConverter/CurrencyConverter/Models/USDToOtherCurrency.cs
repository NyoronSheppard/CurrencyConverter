using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    //Class 1 Dollar = x Currency
    public class USDToOtherCurrency
    {
        //USD to EUR
        private float toEUR;

        //USD to GBP
        private float toGBP;

        //USD to USD
        private float toUSD;

        //USD to CAD
        private float toCAD;

        //USD to BRL
        private float toBRL;

        //USD to CNY
        private float toCNY;

        //USD to HKD
        private float toHKD;

        //USD to JPY
        private float toJPY;

        //USD to MXN
        private float toMXN;

        //USD to NZD
        private float toNZD;

        //USD to NOK
        private float toNOK;

        //USD to RUB
        private float toRUB;

        //USD to SEK
        private float toSEK;

        //New Currency

        //USD to BGN
        private float toBGN;

        //USD to CHF
        private float toCHF;

        //USD to CZK
        private float toCZK;

        //USD to DKK
        private float toDKK;

        //USD to HRK
        private float toHRK;

        //USD to HUF
        private float toHUF;

        //USD to IDR
        private float toIDR;

        //USD to INR
        private float toINR;

        //USD to KRW
        private float toKRW;

        //USD to LTL
        private float toLTL;

        //USD to PLN
        private float toPLN;

        //USD to RON
        private float toRON;

        //Constructor
        public USDToOtherCurrency()
        {
            //1 currency = ... Dollar
            toEUR = 1.37f;
            toGBP = 1.66f;
            toUSD = 1f;
            toCAD = 0.91f;
            toBRL = 0.44f;
            toCNY = 0.16f;
            toHKD = 0.13f;
            toJPY = 0.0096f;
            toMXN = 0.076f;
            toNZD = 0.85f;
            toNOK = 0.17f;
            toRUB = 0.028f;
            toSEK = 0.15f;
            toBGN = 0.703f;
            toCHF = 1.135f;
            toCZK = 0.05f;
            toDKK = 0.184f;
            toHRK = 0.181f;
            toHUF = 0.0045f;
            toIDR = 0.000087f;
            toINR = 0.0166f;
            toKRW = 0.001f;
            toLTL = 0.4f;
            toPLN = 0.33f;
            toRON = 0.31f;
        }

        //Get one Currency
        public float getCurrency(String curr)
        {
            float currency = 0.0f;

            if (curr == "USD")
            {
                currency = toUSD;
            }
            else if (curr == "EUR")
            {
                currency = toEUR;
            }
            else if (curr == "GBP")
            {
                currency = toGBP;
            }
            else if (curr == "CAD")
            {
                currency = toCAD;
            }
            else if (curr == "BRL")
            {
                currency = toBRL;
            }
            else if (curr == "CNY")
            {
                currency = toCNY;
            }
            else if (curr == "HKD")
            {
                currency = toHKD;
            }
            else if (curr == "JPY")
            {
                currency = toJPY;
            }
            else if (curr == "MXN")
            {
                currency = toMXN;
            }
            else if (curr == "NZD")
            {
                currency = toNZD;
            }
            else if (curr == "NOK")
            {
                currency = toNOK;
            }
            else if (curr == "RUB")
            {
                currency = toRUB;
            }
            else if (curr == "SEK")
            {
                currency = toSEK;
            }

            //New Currency
            else if (curr == "BGN")
            {
                currency = toBGN;
            }
            else if (curr == "CHF")
            {
                currency = toCHF;
            }
            else if (curr == "CZK")
            {
                currency = toCZK;
            }
            else if (curr == "DKK")
            {
                currency = toDKK;
            }
            else if (curr == "HRK")
            {
                currency = toHRK;
            }
            else if (curr == "HUF")
            {
                currency = toHUF;
            }
            else if (curr == "IDR")
            {
                currency = toIDR;
            }
            else if (curr == "INR")
            {
                currency = toINR;
            }
            else if (curr == "KRW")
            {
                currency = toKRW;
            }
            else if (curr == "LTL")
            {
                currency = toLTL;
            }
            else if (curr == "PLN")
            {
                currency = toPLN;
            }
            else if (curr == "RON")
            {
                currency = toRON;
            }

            return currency;
        }
    }
}
