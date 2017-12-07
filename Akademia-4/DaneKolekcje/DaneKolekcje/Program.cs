using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace DaneKolekcje
{
    class Program
    {
        static void Main(string[] args)
        {
            string allCountriesUri = "https://restcountries.eu/rest/v2/all";
            string url_new = "https://restcountries.eu/rest/v2/alpha/col";
            string url = "http://api.worldbank.org/v2/incomeLevels/LIC/countries?format=json";
            string json;

            HttpWebRequest httpRequest = (HttpWebRequest) WebRequest.Create(allCountriesUri);
            using (HttpWebResponse httpReponse = (HttpWebResponse)httpRequest.GetResponse())
            using (Stream stream = httpReponse.GetResponseStream())
            using (StreamReader reader=new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }

            List<Country> countries =  JsonConvert.DeserializeObject<List<Country>>(json);

            countries.Sort(new CompareCountries());

            Country poland = new Country();
            poland.NAME = "xyz";

            foreach(Country country in countries)
            {
                if(country.NAME == "Poland")
                {
                    poland = country;
                }
            }

            Console.WriteLine(poland.NAME + poland.Population);

           
        }
    }
}
