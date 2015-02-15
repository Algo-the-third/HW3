using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btl.generic;
using System.Collections;

namespace TSP
{
    class GeneticAlgorithmStrategy : SimulatedAnnealingStrategy
    {
        double[] bestValues;
        double bestFitness;


        double[] worstValues;
        double worstFitness;

        /// <summary>
        /// Random number generator object.
        /// We allow the GUI to set the seed for the random number generator to assist in debugging.
        /// This allows errors to be easily reproduced.
        /// </summary>
        Random rand;

        /// <summary>
        /// The complete list of all the tours.
        /// </summary>
        Population population;

        /// <summary>
        /// The list of cities where we are trying to find the best tour.
        /// </summary>
        Cities cityList = new Cities();

        /// <summary>
        /// The class that does all the work in the TSP algorithm.
        /// If this is not null, then the algorithm is still running.
        /// </summary>
        Tsp tsp;

        public void doGenetics(double closeCityRate, double mutationRate, int populationSize, int generationSize, int genomeSize, Boolean elitism, int elitismRate, int groupsize)
        {
            //Merge our cityinformation in the other schema
            cityList.fillCitiesWithCurrentCitiesInRoute();
            cityList.CalculateCityDistances(Convert.ToInt32(closeCityRate));
            tsp = new Tsp();

            tsp.Begin(populationSize, generationSize, groupsize, Convert.ToInt32(mutationRate), 0, Convert.ToInt32(closeCityRate), cityList);
         
            tsp = null;
          

           // ArrayList startPopulation = createStartPopulation(populationSize);

           // GA geneticAlgoritm = new GA(crossoverRate, mutationRate, populationSize, generationSize, genomeSize);
           // geneticAlgoritm.setElisitmMode(elitism);
           // geneticAlgoritm.setElistimRate(elitismRate);

           // geneticAlgoritm.Go();

           // geneticAlgoritm.GetBest(out bestValues, out bestFitness);
           // geneticAlgoritm.GetWorst(out worstValues, out worstFitness);

           // calculateOrder(geneticAlgoritm.getCurrentOrder());
        }

        private void calculateOrder(List<double> cityOrder)
        {
         
            List<int> localCities = CityPositions.getInstance().getCurrentRouteNodesList();
            int cityCount = CityPositions.getInstance().getRouteCount();

            currentOrder = new List<int>();

            int currentNextCity = 0;
            int counter = 0;
            while (counter < cityOrder.Count)
            {
             
                double minDistance = 99999;
                for (int j = 0; j < cityOrder.Count; j++)
                {
                    //Look for the current City distances for each city 
                    double distance = cityOrder[j];
                    //Look for shorter or equal distance to the next city 
                    if (distance <= minDistance )
                    {
                        int city = localCities[j];
                        if (!nextRandomOrder.Contains(city))
                        {
                            minDistance = distance;
                            currentNextCity = city;
                        }
                    }

                }
                    nextRandomOrder.Add(currentNextCity);
                    counter++;
                
            }


            for (int i = 0; i < nextRandomOrder.Count; i++)
            {
                currentOrder.Add(nextRandomOrder[i]);
            }


        }


        /// <summary>
        /// Create the start population with the given size.
        /// 
        /// Each genome will have a (maybe different) arrangement of cities on the current route.
        /// </summary>
        /// <param name="populationSize"></param>
        /// <returns></returns>
        protected ArrayList createStartPopulation(int populationSize)
        {
            ArrayList startPopulation = new ArrayList();

            for (int populationNumber = 0; populationNumber < populationSize; populationNumber++)
            {
                Genome populationGenome = new Genome();

                // hand in a random arrangement of cities on route
                populationGenome.m_genes = Util.toDoubleArray(this.GetNextRandomArrangement(this.currentOrder));

                startPopulation.Add(populationGenome);
            }

            return startPopulation;
        }

        public double[] getBestValues()
        {
            return this.bestValues;
        }

        public double getBestFitness()
        {
            return this.bestFitness;
        }

        public double[] getWorstValues()
        {
            return this.worstValues;
        }

        public double getWorstFitness()
        {
            return this.worstFitness;
        }
    }
}
