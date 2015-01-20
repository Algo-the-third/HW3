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
            displayCitiesInCheckBox();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            foreach (City city in CityPositions.getInstance().getRoute())
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


        private void displayCitiesInCheckBox()
        {
            checkedListBox.Items.Clear();

            List<City> cities = CityPositions.getInstance().getCities();

            foreach (City c in cities)
            {
                checkedListBox.Items.Add(c);
            }
            
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, true);
            }

            foreach (City c in checkedListBox.Items)
            {
                updateRoute(c);
            }

        }
  private void updateRoute(City city)
        {
            CityPositions cityPostion = CityPositions.getInstance();


            if (chartCities.Series.IsUniqueName("Route"))
            {
                chartCities.Series.Add("Route");
                chartCities.Series[1].ChartType = SeriesChartType.FastLine;
                chartCities.Series[1].IsVisibleInLegend = false;
            }

            // remove city
            if (cityPostion.getRoute().Contains(city))
            {
                cityPostion.removeCityFromRoute(city);

                chartCities.Series[0].Points[city.getNode()].Color = Color.Blue;

                // reload line graph
                chartCities.Series[1].Points.Clear();

                foreach (City c in cityPostion.getRoute())
                {
                    chartCities.Series[1].Points.AddXY(c.getX(), c.getY());
                }

                if (cityPostion.getRouteCount() > 1)
                {
                    chartCities.Series[1].Points.AddXY(cityPostion.getRouteNodeAt(0).getX(), cityPostion.getRouteNodeAt(0).getY());
                }

                // update check box
                checkedListBox.SetItemChecked(city.getNode(), false);
            }
            //add city
            else
            {
                cityPostion.addCityToRoute(city);
                chartCities.Series[0].Points[city.getNode()].Color = Color.Green;
                // reload line graph
                chartCities.Series[1].Points.Clear();

                foreach (City c in cityPostion.getRoute())
                {
                    chartCities.Series[1].Points.AddXY(c.getX(), c.getY());
                }

                chartCities.Series[1].Points.AddXY(city.getX(), city.getY());

                if (cityPostion.getRouteCount() > 1)
                {
                    chartCities.Series[1].Points.AddXY(cityPostion.getRouteNodeAt(0).getX(), cityPostion.getRouteNodeAt(0).getY());
                }

                checkedListBox.SetItemChecked(city.getNode(), true);
               }
            }
        }




       

        
    
}
