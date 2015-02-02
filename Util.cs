using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class Util
    {
        public static double[] toDoubleArray(List<int> inputList)
        {
            double[] doubleAr = new double[inputList.Count];

            for (int index = 0; index < inputList.Count; index++)
            {
                doubleAr[index] = inputList[index];
            }

            return doubleAr;
        }

        public static String toString(double[] doubleValues, String delimiter)
        {
            if (null == doubleValues)
            {
                return "";
            }

            String val = "";
            foreach (double doubleValue in doubleValues) {
                if (!"".Equals(val))
                {
                    val += delimiter;
                }
                val += doubleValue;
            }

            return val;
        }
    }
}
