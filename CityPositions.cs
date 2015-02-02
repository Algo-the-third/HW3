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
        private List<City> sortedRoute;

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

        public void addCityToRoute(City city)
        {
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

        public List<City> getSortedRoute()
        {
            return sortedRoute;
        }

        public List<int> getCurrentRouteNodesList()
        {
            List<int> list = new List<int>();
            foreach (City c in route)
            {
                list.Add(c.getNodeId());
            }
            return list;
        }

        /// <summary>
        /// Method generates a List of Cities based on the given shortest route Nodelist. 
        /// </summary>
        /// <param name="list">List of (sorted) NodeIDs as defined in City instances</param>
        public void generateSortedRouteByGivenNodelist(List<int> list)
        {
            sortedRoute = new List<City>();
            foreach (int i in list)
            {
                foreach (City city in route)
                {
                    if (city.getNodeId() == i)
                    {
                        sortedRoute.Add(city);
                        break;
                    }
                }
            }

        }

    }
}
