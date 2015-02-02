using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class Distance
    {

        /// <summary>
        /// calculate distance between two cities via pythagoras
        /// 
        /// TODO pythagoras good enough or should we also consider the sphere characteristics of the earth?
        /// -> see our WebApp project JumpUp for a possible solution: https://github.com/sasfeld/JumpUpReloaded/blob/ticket_357105/src/main/java/de/htw/fb4/imi/jumpup/util/math/CoordinateUtil.java
        /// 
        /// We should calculate the radians values.
        /// </summary>
        /// <param name="city1"></param>
        /// <param name="city2"></param>
        /// <returns></returns>
        public double calculateDistance(City city1, City city2)
        {
            double x1 = city1.getX();
            double x2 = city2.getX();
            double y1 = city1.getY();
            double y2 = city2.getY();

            double xDistance = Math.Abs(x2 - x1);
            double yDistance = Math.Abs(y2 - y1);

            double distance = Math.Sqrt(Math.Pow((xDistance), 2) + Math.Pow((yDistance), 2));

            return distance;
        }

        /// <summary>
        /// calculate total distance between cities in order of occurance in the route
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        public double calculateTotalRouteDistance()
        {
            double result = 0f;

            List<City> route = CityPositions.getInstance().getRoute();

            for (int i = 1; i < route.Count; i++)
            {
                result += calculateDistance(route[i], route[i - 1]);
            }

            if (route.Count > 1)
            {
                result += calculateDistance(route[0], route[route.Count - 1]);
            }

            return result;
        }

        public double calculateTotalRouteDistance(List<City> route)
        {
            double result = 0f;

            for (int i = 1; i < route.Count; i++)
            {
                result += calculateDistance(route[i], route[i - 1]);
            }

            if (route.Count > 1)
            {
                result += calculateDistance(route[0], route[route.Count - 1]);
            }

            return result;
        }

    }
}
