using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Validation;

namespace MVC_Countries
{
    public class CountryController
    {       
        public List<Country> CountryDb = new List<Country>()
        {
            new Country("USA", "North America", new List<string>() {"Red", "White", "Blue"}),
            new Country("France", "Europe", new List<string>() {"White", "Red", "Blue" }),
            new Country("Canada", "North America", new List<string>() {"Red", "White"}),
            new Country("Mexico", "North America", new List<string>() {"Red", "White", "Green"}),
            new Country("Brazil", "South America", new List<string>() {"Blue", "Green", "Yellow"}),
            new Country("Japan", "Asia", new List<string>() {"Red", "White"}),
            new Country("India", "Asia", new List<string>() { "Saffron", "White", "Green" })
        };
        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }
        public void WelcomeAction()
        {
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            bool runProgram = true;
            while (runProgram)
            {
                CountryListView list = new CountryListView(CountryDb);
                list.Display();
                int choice = Validation.Validator.GetUserNumberInt();
                CountryAction(CountryDb[choice - 1]);
                runProgram = Validation.Validator.GetContinue();
                Console.Clear();
            }            
        }
    }
}
