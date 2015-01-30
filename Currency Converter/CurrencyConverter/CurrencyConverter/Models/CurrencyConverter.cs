using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Net.NetworkInformation;
using System.Globalization;

namespace CurrencyConverter.Models
{
    //Class to change Currency
    class CurrencyConverter
    {
        //urlCurrencyUSD
        public string urlCurrency { get; set; }

        //Currency Money Change
        public string moneyToResponse { get; set; }

        //Currency Name Changed (Before)
        public string currencyToChanged {get; set;}

        //Currency Name Change (After)
        public string currencyToResponse { get; set; }

        //Currency
        public string currency { get; set; }

        //Constructor
        public CurrencyConverter(string currencyToResponse, string moneyToResponse, string currencyToChanged)
        {
            this.currencyToResponse = currencyToResponse;
            this.moneyToResponse = moneyToResponse;
            this.currencyToChanged = currencyToChanged;

            //URL
            string urlCurrencyAux = "http://devel.farebookings.com/api/curconversor/" + currencyToResponse + "/" + currencyToChanged + "/" + moneyToResponse + "/json";
            this.urlCurrency = @urlCurrencyAux;

            WebClient webClientCurrency = new WebClient();
            webClientCurrency.Headers["Accept"] = "application/json";
            webClientCurrency.DownloadStringCompleted += new DownloadStringCompletedEventHandler(webClient_DownloadCatalogCompletedCurrency);
            webClientCurrency.DownloadStringAsync(new Uri(urlCurrency));

            getCurrency();
        }

        private void webClient_DownloadCatalogCompletedCurrency(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                if (e.Result != null)
                {
                    switch (currencyToChanged)
                    {
                        case "USD":
                            var currencyUSD = JsonConvert.DeserializeObject<USDC>(e.Result);

                            currency = currencyUSD.USD;
                            break;

                        case "EUR":
                            var currencyEUR = JsonConvert.DeserializeObject<EURC>(e.Result);

                            currency = currencyEUR.EUR;
                            break;

                        case "GBP":
                            var currencyGBP = JsonConvert.DeserializeObject<GBPC>(e.Result);

                            currency = currencyGBP.GBP;
                            break;

                        case "CAD":
                            var currencyCAD = JsonConvert.DeserializeObject<CADC>(e.Result);

                            currency = currencyCAD.CAD;
                            break;

                        case "BRL":
                            var currencyBRL = JsonConvert.DeserializeObject<BRLC>(e.Result);

                            currency = currencyBRL.BRL;
                            break;

                        case "CNY":
                            var currencyCNY = JsonConvert.DeserializeObject<CNYC>(e.Result);

                            currency = currencyCNY.CNY;
                            break;

                        case "HKD":
                            var currencyHKD = JsonConvert.DeserializeObject<HKDC>(e.Result);

                            currency = currencyHKD.HKD;
                            break;

                        case "JPY":
                            var currencyJPY = JsonConvert.DeserializeObject<JPYC>(e.Result);

                            currency = currencyJPY.JPY;
                            break;

                        case "MXN":
                            var currencyMXN = JsonConvert.DeserializeObject<MXNC>(e.Result);

                            currency = currencyMXN.MXN;
                            break;

                        case "NZD":
                            var currencyNZD = JsonConvert.DeserializeObject<NZDC>(e.Result);

                            currency = currencyNZD.NZD;
                            break;

                        case "NOK":
                            var currencyNOK = JsonConvert.DeserializeObject<NOKC>(e.Result);

                            currency = currencyNOK.NOK;
                            break;

                        case "RUB":
                            var currencyRUB = JsonConvert.DeserializeObject<RUBC>(e.Result);

                            currency = currencyRUB.RUB;
                            break;

                        case "SEK":
                            var currencySEK = JsonConvert.DeserializeObject<SEKC>(e.Result);

                            currency = currencySEK.SEK;
                            break;

                        case "BGN":
                            var currencyBGN = JsonConvert.DeserializeObject<BGNC>(e.Result);

                            currency = currencyBGN.BGN;
                            break;

                        case "CHF":
                            var currencyCHF = JsonConvert.DeserializeObject<CHFC>(e.Result);

                            currency = currencyCHF.CHF;
                            break;

                        case "CZK":
                            var currencyCZK = JsonConvert.DeserializeObject<CZKC>(e.Result);

                            currency = currencyCZK.CZK;
                            break;

                        case "DKK":
                            var currencyDKK = JsonConvert.DeserializeObject<DKKC>(e.Result);

                            currency = currencyDKK.DKK;
                            break;

                        case "HRK":
                            var currencyHRK = JsonConvert.DeserializeObject<HRKC>(e.Result);

                            currency = currencyHRK.HRK;
                            break;

                        case "HUF":
                            var currencyHUF = JsonConvert.DeserializeObject<HUFC>(e.Result);

                            currency = currencyHUF.HUF;
                            break;

                        case "IDR":
                            var currencyIDR = JsonConvert.DeserializeObject<IDRC>(e.Result);

                            currency = currencyIDR.IDR;
                            break;

                        case "INR":
                            var currencyINR = JsonConvert.DeserializeObject<INRC>(e.Result);

                            currency = currencyINR.INR;
                            break;

                        case "KRW":
                            var currencyKRW = JsonConvert.DeserializeObject<KRWC>(e.Result);
                            
                            currency = currencyKRW.KRW;
                            break;

                        case "LTL":
                            var currencyLTL = JsonConvert.DeserializeObject<LTLC>(e.Result);

                            currency = currencyLTL.LTL;
                            break;

                        case "PLN":
                            var currencyPLN = JsonConvert.DeserializeObject<PLNC>(e.Result);

                            currency = currencyPLN.PLN;
                            break;

                        case "RON":
                            var currencyRON = JsonConvert.DeserializeObject<RONC>(e.Result);

                            currency = currencyRON.RON;
                            break;
                    }
                }
            }
            catch
            {
                currency = "Error";
            }
        }

        //GetCurrency
        public string getCurrency()
        {
            return currency;
        }

        //USD Currency
        public class USDC
        {
            public string USD { get; set; }
        }

        //EUR Currency 
        public class EURC
        {
            public string EUR { get; set; }
        }

        //GBP Currency
        public class GBPC
        {
            public string GBP { get; set; }
        }

        //BRL Currency
        public class BRLC
        {
            public string BRL { get; set; }
        }

        //CAD Currency
        public class CADC
        {
            public string CAD { get; set; }
        }

        //CNY Currency
        public class CNYC
        {
            public string CNY { get; set; }
        }

        //HKD Currency
        public class HKDC
        {
            public string HKD { get; set; }
        }

        //JPY Currency
        public class JPYC
        {
            public string JPY { get; set; }
        }

        //MXN Currency
        public class MXNC
        {
            public string MXN { get; set; }
        }

        //NZD Currency
        public class NZDC
        {
            public string NZD { get; set; }
        }

        //NOK Currency
        public class NOKC
        {
            public string NOK { get; set; }
        }

        //RUB Currency
        public class RUBC
        {
            public string RUB { get; set; }
        }

        //SEK Currency
        public class SEKC
        {
            public string SEK { get; set; }
        }

        //New Currency

        //BGN Currency
        public class BGNC
        {
            public string BGN { get; set; }
        }

        //CHF Currency
        public class CHFC
        {
            public string CHF { get; set; }
        }

        //CZK Currency
        public class CZKC
        {
            public string CZK { get; set; }
        }

        //DKK Currency
        public class DKKC
        {
            public string DKK { get; set; }
        }

        //HRK Currency
        public class HRKC
        {
            public string HRK { get; set; }
        }

        //HUF Currency
        public class HUFC
        {
            public string HUF { get; set; }
        }

        //IDR Currency
        public class IDRC
        {
            public string IDR { get; set; }
        }

        //INR Currency
        public class INRC 
        {
            public string INR { get; set; }
        }

        //KRW Currency
        public class KRWC
        {
            public string KRW { get; set; }
        }

        //LTL Currency
        public class LTLC
        {
            public string LTL { get; set; }
        }

        //PLN Currency
        public class PLNC
        {
            public string PLN { get; set; }
        }

        //RON Currency
        public class RONC
        {
            public string RON { get; set; }
        }
    }
}
