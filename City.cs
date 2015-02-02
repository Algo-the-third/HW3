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
        private int nodeId;

        public City(int nodeId, double x, double y)
        {
            this.nodeId = nodeId;
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

        public void setNodeId(int nodeId)
        {
            this.nodeId = nodeId;
        }

        public int getNodeId()
        {
            return nodeId;
        }

        
        public override string ToString()
        {
            return "Node:" + nodeId + " X:" + x + " Y: " + y; 
            
        }

    }
}
