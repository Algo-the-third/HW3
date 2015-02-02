using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class FileLoader
    {

        public void loadPostions()
        {
            CityPositions cityPositons = CityPositions.getInstance();

            StreamReader streamReader = new StreamReader(Constants.cityPositions);

            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                if (!line.Contains("NODE"))
                {
                   
                    string[] split = line.Split(' ');
                    
                    int nodeId = (int)Convert.ToDouble(split[0]) - 1;
                    double x = (double)Convert.ToDouble(split[1]);
                    double y = (double)Convert.ToDouble(split[2]);

                    cityPositons.addCityNode(new City(nodeId, x, y));
                                       
                }
            }

            streamReader.Close();
                       
        }
    }
}
