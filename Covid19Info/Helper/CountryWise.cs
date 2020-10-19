using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Info.Helper 
{
    public class CountryWise
    {
        public Confirmed confirmed { get; set; }
        public Recovered recovered { get; set; }
        public Deaths deaths { get; set; }
        public DateTime lastUpdate { get; set; }
        public string countryName { get; set; } 
    }
    public class Confirmed
    {
        public int value { get; set; }
        public string detail { get; set; }
    }

    public class Recovered
    {
        public int value { get; set; }
        public string detail { get; set; }
    }

    public class Deaths
    {
        public int value { get; set; }
        public string detail { get; set; }
    }

   
}
