using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    abstract class Constants
    {
        public static String cityPositionsFile = "../../data/tsp_PolskaCities.txt";
        public static String GREEDY = "Greedy Strategy";
        public static String ANNEALING = "Simulated Annealing";
        public static String GENETIC = "Genetic Algorithm";

    }
}
