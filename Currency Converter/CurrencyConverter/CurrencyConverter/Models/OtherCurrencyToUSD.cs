using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    //Currency = x Dollar
    public class OtherCurrencyToUSD
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
        public OtherCurrencyToUSD()
        {
            //1 dollar = ...
            toEUR = 0.73f;
            toGBP = 0.6f;
            toUSD = 1f;
            toCAD = 1.1f;
            toBRL = 2.28f;
            toCNY = 6.21f;
            toHKD = 7.76f;
            toJPY = 103.92f;
            toMXN = 13.13f;
            toNZD = 1.17f;
            toNOK = 6f;
            toRUB = 35.57f;
            toSEK = 6.55f;
            toBGN = 1.42f;
            toCHF = 0.881f;
            toCZK = 19.897f;
            toDKK = 5.41f;
            toHRK = 5.52f;
            toHUF = 222.57f;
            toIDR = 11494f;
            toINR = 60.275f;
            toKRW = 1042f;
            toLTL = 2.5f;
            toPLN = 3.03f;
            toRON = 3.23f;
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
