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

        public double fitnessFunction(double[] values)
        {
            // TODO evaluate fitness function, should somehow compare distances
            if (values.GetLength(0) != 3)
            {
                throw new ArgumentOutOfRangeException("should only have 3 args");
            }
            
            double x = values[0];
            double y = values[1];
            double z = values[2];
            double w = x - y + z;

            return w; 
        }

        public void doGenetics(double crossoverRate, double mutationRate, int populationSize, int generationSize, int genomeSize, Boolean elitism, int elitismRate)
        {
            // TODO where to handle startPopulation genomes??
            ArrayList startPopulation = createStartPopulation(populationSize);

            GA geneticAlgoritm = new GA(crossoverRate, mutationRate, populationSize, generationSize, genomeSize);
            geneticAlgoritm.setElisitmMode(elitism);
            geneticAlgoritm.setElistimRate(elitismRate);

            geneticAlgoritm.FitnessFunction = new GAFunction(this.fitnessFunction);
           
            geneticAlgoritm.Go();

            geneticAlgoritm.GetBest(out bestValues, out bestFitness);
            geneticAlgoritm.GetWorst(out worstValues, out worstFitness);
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
