using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TSP
{
    public class SimulatedAnnealingStrategy
    {
        private string filePath;
        protected List<int> currentOrder = new List<int>();
        protected List<int> nextRandomOrder = new List<int>();
        protected double[,] distances;
        private Random random = new Random();
        protected double shortestDistance = 0;

        double temperature = 10000.0;
        double coolingRate = 0.9999;
        double absoluteTemperature = 0.00001;

        public double ShortestDistance
        {
            get
            {
                return shortestDistance;
            }
            set
            {
                shortestDistance = value;
            }
        }

        public void setCurrentOrder(List<int> currentOrder)
        {
            this.currentOrder = currentOrder;
          
        }

        public List<int> CitiesOrder
        {
            get
            {
                return currentOrder;
            }
            set
            {
                currentOrder = value;
            }
        }


        /// <summary>
        /// Calculate the total distance which is the objective function
        /// </summary>
        /// <param name="order">A list containing the order of cities (nodeIds of City instances in CityPositions)</param>
        /// <returns></returns>
        protected double GetTotalDistance(List<int> order)
        {
            double distance = 0;

            for (int i = 0; i < order.Count - 1; i++)
            {
                distance += distances[order[i], order[i + 1]];
            }

            if (order.Count > 0)
            {
                distance += distances[order[order.Count - 1], 0];
            }

            return distance;
        }

        /// <summary>
        /// Get the next random arrangements of cities
        /// </summary>
        /// <param name="order"></param>
        /// <returns>List containing the nodeIds of City instances in the CityPositions collection.</returns>
        private List<int> GetNextArrangement(List<int> order)
        {
            List<int> newOrder = new List<int>();

            for (int i = 0; i < order.Count; i++)
                newOrder.Add(order[i]);

            //we will only rearrange two cities by random
            //starting point should be always zero - so zero should not be included

            int firstRandomCityIndex = random.Next(1, newOrder.Count);
            int secondRandomCityIndex = random.Next(1, newOrder.Count);

            int dummy = newOrder[firstRandomCityIndex];
            newOrder[firstRandomCityIndex] = newOrder[secondRandomCityIndex];
            newOrder[secondRandomCityIndex] = dummy;

            return newOrder;
        }




        public void setTemperature(double temperature)
        {
            this.temperature = temperature;
        }

        public void setCoolingRate(double coolingRate)
        {
            this.coolingRate = coolingRate;
        }

        public void setAbsoluteTemperature(double absoluteTemperature)
        {
            this.absoluteTemperature = absoluteTemperature;
        }

        /// <summary>
        /// Annealing Process
        /// </summary>
        public void Anneal()
        {
            int iteration = -1;

            //  double temperature = 10000.0;
            double deltaDistance = 0;
            //  double coolingRate = 0.9999;
            //  double absoluteTemperature = 0.00001;



            double currentDistance = GetTotalDistance(currentOrder);

            while (temperature > absoluteTemperature)
            {
                nextRandomOrder = GetNextArrangement(currentOrder);

                deltaDistance = GetTotalDistance(nextRandomOrder) - currentDistance;

                //if the new order has a smaller distance
                //or if the new order has a larger distance but satisfies Boltzman condition then accept the arrangement
                if ((deltaDistance < 0) || (currentDistance > 0 && Math.Exp(-deltaDistance / temperature) > random.NextDouble()))
                {
                    // store new order of cities on route
                    for (int i = 0; i < nextRandomOrder.Count; i++)
                        currentOrder[i] = nextRandomOrder[i];

                    currentDistance = deltaDistance + currentDistance;
                }

                //cool down the temperature
                temperature *= coolingRate;

                iteration++;
            }

            shortestDistance = currentDistance;
        }

        /**
         * New Method for calculating the distance matrix out of the existing route in CityPostions class.
         * 
         */
        public void generateCurrentOrder()
        {

            List<City> route = CityPositions.getInstance().getRoute();

            Distance distance = new Distance();

            int routeCount = route.Count;

            distances = new double[routeCount, routeCount];

            for (int i = 0; i < routeCount; i++)
            {
                for (int j = 0; j < routeCount; j++)
                {
                    double d = distance.calculateDistance(route[i], route[j]);
                    distances[i, j] = d;
                }
                //the number of rows in this matrix represent the number of cities
                //we are representing each city by an index from 0 to N - 1
                //where N is the total number of cities
                currentOrder.Add(i);
            }

            if (currentOrder.Count < 1)
                throw new Exception("No cities to order.");


        }


    }


}