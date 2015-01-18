using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TSP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Load += new EventHandler(MainForm_Load);
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            new FileLoader().loadPostions();
            displayCitiesOnChart();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            foreach (City city in CityPositions.getInstance().getCities())
            {
                Console.WriteLine(city.getNode());
            }
        }


        private void displayCitiesOnChart()
        {
            chartCities.Series[0].Points.Clear();
            chartCities.Series[0].ChartType = SeriesChartType.Point;

            // Make the chart free from label and raster
            chartCities.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartCities.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chartCities.Series[0].IsVisibleInLegend = false;
         
            foreach(City city in CityPositions.getInstance().getCities())
            {
                chartCities.Series[0].Points.AddXY(city.getX(), city.getY());
                chartCities.Series[0].Points[chartCities.Series[0].Points.Count - 1].Color = Color.Blue;
                // add label
                chartCities.Series[0].Points[chartCities.Series[0].Points.Count - 1].Label = city.getNode().ToString();
            }
        }


        private void updateRoute(City city)
        {

            CityPositions cityPostions = CityPositions.getInstance();
            List<City> route = cityPostions.getRoute();
            // remove city
            if (route.Contains(city))
            {
                route.Remove(city);

                chartCities.Series[0].Points[city.getNode()].Color = Color.Blue;

                // reload line graph
                chartCities.Series[1].Points.Clear();

                foreach (City c in route)
                {
                    chartCities.Series[1].Points.AddXY(c.getX(), c.getY());
                }

                if (route.Count > 1)
                {
                    chartCities.Series[1].Points.AddXY(route[0].getX(), route[0].getY());
                }

                // update check box
                //routesCBList.SetItemChecked(city.node, false);
            }
            //add city
            else
            {
                route.Add(city);
                chartCities.Series[0].Points[city.getNode()].Color = Color.Green;
                // reload line graph
                chartCities.Series[1].Points.Clear();

                foreach (City c in route)
                {
                    chartCities.Series[1].Points.AddXY(c.getX(), c.getY());
                }

                chartCities.Series[1].Points.AddXY(city.getX(), city.getY());

                if (route.Count > 1)
                {
                    chartCities.Series[1].Points.AddXY(route[0].getX(), route[0].getY());
                }

                //routesCBList.SetItemChecked(city.node, true);
            }
        }


        
    }
}
