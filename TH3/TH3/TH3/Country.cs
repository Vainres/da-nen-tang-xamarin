using System;
using System.Collections.Generic;
using System.Text;

namespace TH3
{
    public class Country : List<City>
    {
        public string CountryName { get; set; }
        public string Description { get; set; }

        public Country(string name)
        {
            CountryName = name;
        }

    }
}
