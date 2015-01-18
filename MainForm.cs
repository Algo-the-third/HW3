using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            foreach (City city in CityPositions.getInstance().getCities())
            {
                Console.WriteLine(city.getNode());
            }
        }
    }
}
