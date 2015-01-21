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

        DataPoint currentDataPoint;
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

            List<int> currentOrder = new List<int>();
            String mode = TabArea.SelectedTab.Text;
            switch (mode)
            {
                case "Simulated Annealing":
                    {
                        CityPositions cityPositions = CityPositions.getInstance();
                        foreach (City city in cityPositions.getRoute())
                        {
                            currentOrder.Add(city.getNode());
                        }
                        double temperature = (double)numTemperature.Value;
                        double coolingRate = (double)numCoolingRate.Value;
                        double absoluteTemperature = (double)numAbsoluteTemperature.Value;

                        // calculate new order
                        TravellingSalesmanProblem tsp = new TravellingSalesmanProblem();
                        



                    
                    
                    
                    }
                    break;
                case "Greedy Strategy":
                    { }
                    break;
                case "Genetic Algorithm":
                    { }
                    break;
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

            foreach (City city in CityPositions.getInstance().getCities())
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
            displayRouteDistance();

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

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            City selectedCity = CityPositions.getInstance().getCityNodeAt(checkedListBox.SelectedIndex);

            updateRoute(selectedCity);

            displayRouteDistance();


        }


        private void chartCities_Click(object sender, EventArgs e)
        {
            // add DataPoint which has been clicked on
            if (currentDataPoint != null)
            {
                updateRoute(getCityAtPostion(currentDataPoint));
                displayRouteDistance();
            }
        }


        private City getCityAtPostion(DataPoint point)
        {
            // compare coordinate with every known city
            foreach (City city in CityPositions.getInstance().getCities())
            {
                if (city.getX() == point.XValue && city.getY() == point.YValues[0])
                {
                    return city;
                }
            }
            return null;
        }



        private void chartCities_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // get currently selected chart element
            HitTestResult result = chartCities.HitTest(e.X, e.Y);

            currentDataPoint = null;

            // update data point colors
            foreach (DataPoint point in chartCities.Series[0].Points)
            {
                // reset to blue
                point.Color = Color.Blue;

                // set green if it is a city within the route
                foreach (City city in CityPositions.getInstance().getRoute())
                {
                    if (city.getX() == point.XValue && city.getY() == point.YValues[0])
                    {
                        point.Color = Color.Green;
                    }
                }
            }

            // check if selected element is a data point
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                // check if selected data point is a point and not a line
                if (result.Series.Name.Contains("Series1"))
                {
                    DataPoint point = chartCities.Series[0].Points[result.PointIndex];

                    // change color to red while hovering over it
                    point.Color = Color.Red;

                    // save data point
                    currentDataPoint = point;
                }
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            CityPositions postions = CityPositions.getInstance();
            List<City> missingCities = new List<City>();

            foreach (City city in postions.getCities())
            {
                if (!postions.cityIsInRoute(city))
                    missingCities.Add(city);
            }

            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, true);
            }

            foreach (City city in missingCities)
            {
                updateRoute(city);
            }
            displayRouteDistance();

        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            CityPositions postions = CityPositions.getInstance();
            List<City> missingCities = new List<City>();

            foreach (City city in postions.getCities())
            {
                if (postions.cityIsInRoute(city))
                    missingCities.Add(city);
            }
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }

            foreach (City city in missingCities)
            {
                updateRoute(city);
            }
            displayRouteDistance();

        }


        private void displayRouteDistance()
        {
            distanceLabel.Text = new Distance().calculateTotalRouteDistance() + "";
        }


        /**
         * Appends the resultTextBox from any Thread state, just call it inside another thread. 
         */
        private void appendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(appendTextBox), new object[] { value });
                return;
            }
      
            resultTextBox.AppendText("\r\n" + value);
        }

    }

}
