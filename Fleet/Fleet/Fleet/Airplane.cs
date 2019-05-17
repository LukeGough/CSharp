/*  
    Class: Cluster - Programming II
    Name: Luke Gough
    Student ID: 30003918
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fleet
{
    class Airplane : Vehicle
    {
        // private attributes
        private int noEngines;
        private string engineType;

        // default constructor
        public Airplane()
        {
            noEngines = 0;
            engineType = "";
        }

        // overloaded constructor
        public Airplane(string make, string model, int year, int noEngines, string engineType)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.noEngines = noEngines;
            this.engineType = engineType;
        }

        // set and get's
        public int getNoEngines()
        {
            return noEngines;
        }

        public void setNoEgines(int noEngines)
        {
            this.noEngines = noEngines;
        }

        public string getEngineType()
        {
            return engineType;
        }

        public void setEngineType(string engineType)
        {
            this.engineType = engineType;
        }

        // display method
        public override string Display()
        {
            return (make + " " + model + " " + year + " " + noEngines + " " + engineType);
        }
    }
}
