using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    /**
     * Algorithm used the nearest neighbour behaviour in order to get the local optimums.
     * */
    class GreedyStrategy : SimulatedAnnealingStrategy
    {



        public void calculateNNRoute()
        {

            List<int> localCities = CityPositions.getInstance().getCurrentRouteNodesList();
            List<int> localCitiesClean = CityPositions.getInstance().getCurrentRouteNodesList();
            int cityCount = CityPositions.getInstance().getRouteCount();

            currentOrder = new List<int>();

            int currentNextCity = 0;
            while (!(localCities.Count == 0))
            {

             
                int indexToRemove = 0;
                if (currentNextCity == 0)
                {
                    currentNextCity = localCities[0];
                    nextRandomOrder.Add(currentNextCity);
                }

                for (int i = 0; i < localCities.Count; i++)
                {

                    if (localCities[i] == currentNextCity)
                    {
                        indexToRemove = i;
                        break;
                    }
                }

                localCities.RemoveAt(indexToRemove);

                int row = localCitiesClean.IndexOf(currentNextCity);
                double minDistance = 99999;
                for (int j = 0; j < cityCount; j++)
                {
                    //Look for the current City distances for each city 
                    double distance = distances[row, j];
                    //Look for shorter or equal distance to the next city 
                    if (distance <= minDistance & distance != 0 & distance != distances[row, row])
                    {
                       
                        //save the possible next city if not already in the route
                        int city = localCitiesClean[j];
                        if (!nextRandomOrder.Contains(city))
                        {
                            minDistance = distance;
                            currentNextCity = city;
                        }
                    }

                }

              
                //save the shortest city from the current in the list;
                if (!nextRandomOrder.Contains(currentNextCity))
                {
                    nextRandomOrder.Add(currentNextCity);
                }
            }


            for (int i = 0; i < nextRandomOrder.Count; i++)
            {
                currentOrder.Add(nextRandomOrder[i]);
            }


        }

    }
}
