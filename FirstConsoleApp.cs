using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemo
{
    class FirstConsoleApp
    {

        public static void TestFirstApp()
        {
            Country country1 = new Country()
            {
                Code = "AUS",
                Name = "AUSTRALIA",
                Capital = "Canberra"
            };

            Country country2 = new Country()
            {
                Code = "IND",
                Name = "INDIA ",
                Capital = "New Delhi"
            };

            Country country3 = new Country()
            {
                Code = "USA",
                Name = "UNITED STATES",
                Capital = "Washington D.C."
            };

            Country country4 = new Country()
            {
                Code = "GBR",
                Name = "UNITED KINGDOM",
                Capital = "London"
            };

            Country country5 = new Country()
            {
                Code = "CAN",
                Name = "CANADA",
                Capital = "Ottawa"
            };

            List<Country> listCountries = new List<Country>();
            listCountries.Add(country1);
            listCountries.Add(country2);
            listCountries.Add(country3);
            listCountries.Add(country4);
            listCountries.Add(country5);
            Dictionary<string, Country> countriesDict = listCountries.ToDictionary(x => x.Code);
            string userChoice = string.Empty;
            do
            {
                Console.WriteLine("please enter country code");
                string countryCode = Console.ReadLine().ToUpper();

                if (string.IsNullOrEmpty(countryCode))
                {
                    Console.WriteLine("Please enter valid country code");
                }
                else
                {
                   // Country resultCountry = listCountries.Find(country => country.Code == countryCode);
                    Country resultCountry = countriesDict.ContainsKey(countryCode) ? countriesDict[countryCode] : null;
                    if (resultCountry == null)
                    {
                        Console.WriteLine($" country for the country code {countryCode} not found");
                    }
                    else
                    {

                        Console.WriteLine($"Country code {countryCode} Country Name {resultCountry.Name} ");
                       
                    }
                    do
                    {
                        Console.WriteLine("Do you want to continue Yes or No");
                        userChoice = Console.ReadLine().ToUpper();
                    } while (userChoice != "YES" && userChoice != "NO");
                }
            } while (userChoice == "YES");
        }
    }
}
