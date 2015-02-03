using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TSP
{
    public partial class MainForm : Form
    {

        private DataPoint currentDataPoint;
        private static Boolean calculateThreadActive = false;



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
            numElitismRatio_ValueChanged(null,null);

        }




        private void btnCalculate_Click(object sender, EventArgs e)
        {

            String mode = TabArea.SelectedTab.Text;

            if (calculateThreadActive)
            {
                appendTextBox("There is an other calculation process active please wait.");
                return;
            }

            switch (mode)
            {
                case "Simulated Annealing":
                    {                       
                        new Thread(calculateSimulatedAnnealing).Start();
                    }
                    break;
                case "Greedy Strategy":
                    {
                        new Thread(calculateGreedyStrategy).Start();
                    }
                    break;
                case "Genetic Algorithm":
                    {
                        new Thread(calculateGeneticAlgorithm).Start();
                    }
                    break;
            }

        }

        private void calculateSimulatedAnnealing()
        {
            calculateThreadActive = true;
            double temperature;
            double coolingRate;
            double absoluteTemperature;

            try
            {
                temperature = (double)numTemperature.Value;
                coolingRate = Convert.ToDouble(txtCoolingRate.Text);
                absoluteTemperature = Convert.ToDouble(txtAbsoluteTemperature.Text);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                appendTextBox("Your input wasn't valid!");
                calculateThreadActive = false;
                return;
            }

            if (coolingRate <= 0 | coolingRate >= 1)
            {
                appendTextBox("Cooling Rate has to be 0<x<1. Please choose a valid value.");
                return;
            }

            String path = "";
            // calculate new order
            SimulatedAnnealingStrategy problem = new SimulatedAnnealingStrategy();
            problem.setTemperature(temperature);
            problem.setCoolingRate(coolingRate);
            problem.setAbsoluteTemperature(absoluteTemperature);
            problem.generateCurrentOrder();
            problem.Anneal();

            for (int i = 0; i < problem.CitiesOrder.Count - 1; i++)
            {
                path += problem.CitiesOrder[i] + " -> ";
            }
            path += problem.CitiesOrder[problem.CitiesOrder.Count - 1];

            appendTextBox("Simulated Annealing ");
            appendTextBox("Shortest Route: " + path);
            appendTextBox("The shortest distance is: " + problem.ShortestDistance.ToString());


            //Creates a list of Cities in Citypostions based on the given sorted node list.
            CityPositions.getInstance().generateSortedRouteByGivenNodeIdlist(problem.CitiesOrder);
            redrawRouteOnChart();
            displayRouteDistance(problem.ShortestDistance);
            calculateThreadActive = false;
        }


        private void calculateGreedyStrategy()
        {
            calculateThreadActive = true;
            GreedyStrategy greedyStrategy = new GreedyStrategy();
            greedyStrategy.generateCurrentOrder();
            greedyStrategy.calculateNNRoute();

            String path = "";

            for (int i = 0; i < greedyStrategy.CitiesOrder.Count - 1; i++)
            {
                path += greedyStrategy.CitiesOrder[i] + " -> ";
            }
            path += greedyStrategy.CitiesOrder[greedyStrategy.CitiesOrder.Count - 1];

            appendTextBox("Greedy Strategy");
            appendTextBox("Shortest Route: " + path);

            //Creates a list of Cities in Citypostions based on the given sorted node list.
            CityPositions cityPostions = CityPositions.getInstance();
            cityPostions.generateSortedRouteByGivenNodeIdlist(greedyStrategy.CitiesOrder);
            //Calculate current Route distance
            Double currentRouteDistance = new Distance().calculateTotalRouteDistance(cityPostions.getSortedRoute());

            appendTextBox("The shortest distance is: " + currentRouteDistance);
            redrawRouteOnChart();
            displayRouteDistance(currentRouteDistance);
          
            calculateThreadActive = false;

        }

        private void calculateGeneticAlgorithm()
        {
            calculateThreadActive = true;

            try
            {
                double crossoverRate = Convert.ToDouble(numCrossoverRate.Value);
                double mutationRate = Convert.ToDouble(numMutationRate.Value);
                int populationSize = Convert.ToInt32(numPopulationSize.Value);
                int generationSize = Convert.ToInt32(numGenerationSize.Value);
                int genomeSize = Convert.ToInt32(numGenomeSize.Value);
                int elisitmSize = Convert.ToInt32(numElitismRatio.Value);
                //double mixingRatio = Convert.ToDouble(numMixingRatio.Value);
                Boolean elitismMode = elitismCheckbox.Checked;
              

                GeneticAlgorithmStrategy geneticStrategy = new GeneticAlgorithmStrategy();
                geneticStrategy.generateCurrentOrder();

                geneticStrategy.doGenetics(crossoverRate, mutationRate, populationSize, generationSize, genomeSize, elitismMode, elisitmSize);

                appendTextBox("Genetic Algorithm Strategy");
                appendTextBox("Best fitness:" + geneticStrategy.getBestFitness());
                appendTextBox("Best values:" + Util.toString(geneticStrategy.getBestValues(), ", "));
                appendTextBox("Worst fitness:" + geneticStrategy.getWorstFitness());
                appendTextBox("Worst values:" + Util.toString(geneticStrategy.getWorstValues(), ", "));
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
                appendTextBox("Please type in valid numbers.");
            }

            finally
            {
                //to prevent deadlock by conrurrency
                calculateThreadActive = false;
            }
        }

        private void redrawRouteOnChart()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(redrawRouteOnChart), new object[] { });
                return;
            }


            CityPositions cityPostion = CityPositions.getInstance();


            // reload line graph
            chartCities.Series[1].Points.Clear();

            foreach (City c in cityPostion.getSortedRoute())
            {
                chartCities.Series[1].Points.AddXY(c.getX(), c.getY());
            }

            if (cityPostion.getRouteCount() > 1)
            {
                chartCities.Series[1].Points.AddXY(cityPostion.getRouteNodeAt(0).getX(), cityPostion.getRouteNodeAt(0).getY());
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
                chartCities.Series[0].Points[chartCities.Series[0].Points.Count - 1].Label = city.getNodeId().ToString();
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

            selectAllCities();

            foreach (City c in checkedListBox.Items)
            {
                updateRoute(c);
            }
            displayRouteDistance();

        }

        private void selectAllCities()
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, true);
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

                chartCities.Series[0].Points[city.getNodeId()].Color = Color.Blue;

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
                checkedListBox.SetItemChecked(city.getNodeId(), false);
            }
            //add city
            else
            {
                cityPostion.addCityToRoute(city);
                chartCities.Series[0].Points[city.getNodeId()].Color = Color.Green;
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

                checkedListBox.SetItemChecked(city.getNodeId(), true);
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

            selectAllCities();

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

      

        private void displayRouteDistance(double distance)
        {

            if (InvokeRequired)
            {
                this.Invoke(new Action<double>(displayRouteDistance), new object[] { distance });
                return;
            }
            distanceLabel.Text = distance + "";
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

        private void btnRandomRoute_Click(object sender, EventArgs e)
        {
            SimulatedAnnealingStrategy strategy = new SimulatedAnnealingStrategy();
            strategy.generateCurrentOrder();
            List<int> randomArrangement = strategy.GetNextRandomArrangement(strategy.CitiesOrder);

            CityPositions.getInstance().generateSortedRouteByGivenNodeIdlist(randomArrangement);
            Double currentRouteDistance = new Distance().calculateTotalRouteDistance(CityPositions.getInstance().getSortedRoute());

            appendTextBox("Generating random route...");
            appendTextBox("The random distance is " + currentRouteDistance);
            redrawRouteOnChart();
            displayRouteDistance(currentRouteDistance);

            calculateThreadActive = false;
        }

        private void numElitismRatio_ValueChanged(object sender, EventArgs e)
        {

            double populationSize = Convert.ToDouble(numPopulationSize.Value);
            double elisitmSize = Convert.ToDouble(numElitismRatio.Value);

            double percent = elisitmSize / (populationSize / 100);

            elistimRate.Text = percent+"\r\n% of the population.";
        }

        private void numPopulationSize_ValueChanged(object sender, EventArgs e)
        {
            numElitismRatio_ValueChanged(null, null);
        }

    
    }

}
