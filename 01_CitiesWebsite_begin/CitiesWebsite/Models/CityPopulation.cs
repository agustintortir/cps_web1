using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesWebsite.Models
{
    public class CityPopulation
    {
        public int Year { get; }
        public int City { get; }
        public int Urban { get; }
        public int Metro { get; }

        public CityPopulation(int city, int year, int urban, int metro)
        {
            City = city;
            Year = year;
            Urban = urban;
            Metro = metro;

        }
    }
}
