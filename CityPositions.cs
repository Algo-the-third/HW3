using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class CityPositions
    {
        private static volatile CityPositions cityPositions;

        private List<City> cities;

        private CityPositions()
        {
            cities = new List<City>();
        }

        public static CityPositions getInstance()
        {
            if (cityPositions == null)
            {
                cityPositions = new CityPositions();
            }
            return cityPositions;
        }

        public void addCityNode(City city)
        {
            cities.Add(city);
        }

        public List<City> getCities()
        {
            return cities;
        }
    }
}
