using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class City
    {
        private double x;
        private double y;
        private int node;

        public City(int node, double x, double y)
        {
            this.node = node;
            this.x = x;
            this.y = y;
        }

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public void setX(double x)
        {
            this.x = x;
        }

        public void setY(double y)
        {
            this.y = y;
        }

        public void setNode(int node)
        {
            this.node = node;
        }

        public int getNode()
        {
            return node;
        }

        

    }
}
