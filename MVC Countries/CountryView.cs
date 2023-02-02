using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryView
    {
        //property
        public Country DisplayCountry { get; set; }

        //constructor
        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }

        //method
        public void Display()
        {
            Console.WriteLine("Name: " + DisplayCountry.Name);
            Console.WriteLine("Continent: " + DisplayCountry.Continent);
            Console.WriteLine("Flag Colors: ");

            foreach (var color in DisplayCountry.Colors)
            {
                Console.WriteLine(" - " + color);
            }
        }
    }
}
