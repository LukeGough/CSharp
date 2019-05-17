using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fleet
{
    class Boat : Vehicle
    {
        // private attributes
        private string length;
        private string hullType;

        // default constructor
        public Boat()
        {
            length = "";
            hullType = "";
        }

        // overloaded constructor
        public Boat(string make, string model, int year, string length, string hullType)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.length = length;
            this.hullType = hullType;
        }

        // set and get's
        public string getLength()
        {
            return length;
        }

        public void setLength(string length)
        {
            this.length = length;
        }

        public string getHullType()
        {
            return hullType;
        }

        public void setHullType(string hullType)
        {
            this.hullType = hullType;
        }

        // display method
        public override string Display()
        {
            return (make + " " + model + " " + year + " " + length + " " + hullType);
        }
    }
}
