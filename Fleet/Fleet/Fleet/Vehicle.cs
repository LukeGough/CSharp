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
    class Vehicle
    {
        // protected attributes so child classes can access
        protected string make;
        protected string model;
        protected int year;

        // default constructor, although its not neede because we'll only be creating Airplane, Boats and Cars
        public Vehicle()
        {
            make = "";
            model = "";
            year = 0;
        }

        // Set and Get's
        public string getMake()
        {
            return make;
        }

        public void setMake(string make)
        {
            this.make = make;
        }

        public string getModel()
        {
            return model;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public int getYear()
        {
            return year;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public virtual string Display()
        {
            return (make + " " + model + " " + year);
        }
    }
}
