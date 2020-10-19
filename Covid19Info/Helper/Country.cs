using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Info.Helper 
{
    public class CountryInfo
    {
        public List<Country> countries { get; set; }
        

    }
    public class Country 
    {
        public string name { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
    }
}
