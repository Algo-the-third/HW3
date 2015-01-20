using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class CityPositions
    {
        private static CityPositions cityPositions;
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

        public int getRouteCount()
        {
            return route.Count();
        }

        public City getRouteNodeAt(int positon)
        {
            return route[positon];
        }


        public City getCityNodeAt(int positon)
        {
            return cities[positon];
        }

        public Boolean cityIsInRoute(City city)
        {
            if (!route.Contains(city))
            {
                return false;
            }
            return true;
        }

    }
}
