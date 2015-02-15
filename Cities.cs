using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
   /// <summary>
    /// This class contains the list of cities for this test.
    /// Each city has a location and the distance information to every other city.
    /// </summary>
    public class Cities : List<City>
    {
        /// <summary>
        /// Determine the distances between each city.
        /// </summary>
        /// <param name="numberOfCloseCities">When creating the initial population of tours, this is a greater chance
        /// that a nearby city will be chosen for a link. This is the number of nearby cities that will be considered close.</param>
        public void CalculateCityDistances(int numberOfCloseCities)
        {
            foreach (City city in this)
            {
                city.Distances.Clear();

                for (int i = 0; i < Count; i++)
                {
                    city.Distances.Add(Math.Sqrt(Math.Pow((double)(city.Location.X - this[i].Location.X), 2D) +
                                       Math.Pow((double)(city.Location.Y - this[i].Location.Y), 2D)));
                }
            }

            foreach (City city in this)
            {
                city.FindClosestCities(numberOfCloseCities);
            }
        }

        /// <summary>
        /// Open the XML file that contains the list of cities.
        /// </summary>
        /// <param name="fileName">Name of the XML file.</param>
        /// <returns>The city list.</returns>
        /// <exception cref="FileNotFoundException">fileName parameter is invalid.</exception>
        /// <exception cref="InvalidCastException">XML File is not properly formatted.</exception>
        public void OpenCityList(string fileName)
        {
            DataSet cityDS = new DataSet();

            try
            {
                this.Clear();

                cityDS.ReadXml(fileName);

                DataRowCollection cities = cityDS.Tables[0].Rows;

                foreach (DataRow city in cities)
                {
                    this.Add(new City(Convert.ToInt32(city["X"], CultureInfo.CurrentCulture), Convert.ToInt32(city["Y"], CultureInfo.CurrentCulture)));
                }
            }
            finally
            {
                cityDS.Dispose();
            }
        }

        public void fillCitiesWithCurrentCitiesInRoute()
        {
            List<City> cityList = CityPositions.getInstance().getRoute();
            foreach (City c in cityList)
            {
                City city = new City(Convert.ToInt32(c.getX(), CultureInfo.CurrentCulture), Convert.ToInt32(c.getY(), CultureInfo.CurrentCulture));
                city.setNodeId(c.getNodeId());
                city.setX(c.getX());
                city.setY(c.getY());
                this.Add(city);
            }


        }

    }
    }
