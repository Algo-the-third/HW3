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
        private List<City> route;

        private List<City> cities;

        private CityPositions()
        {
            cities = new List<City>();
            route = new List<City>();
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

        public List<City> getRoute()
        {
            return route;
        }

        public void addCityToRoute(City city){
            route.Add(city);
        }

        public void removeCityFromRoute(City city)
        {
            route.Remove(city);
        }

    }
}
