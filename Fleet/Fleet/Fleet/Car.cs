using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fleet
{
    class Car : Vehicle
    {
        // private attributes
        private string bodyType;

        // default constructor
        public Car()
        {
            bodyType = "";
        }

        // overloaded constructor
        public Car(string make, string model, int year, string bodyType)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.bodyType = bodyType;
        }

        // set and get's
        public string getBodyType()
        {
            return bodyType;
        }

        public void setBodyType(string bodyType)
        {
            this.bodyType = bodyType;
        }

        // display method
        public override string Display()
        {
            return (make + " " + model + " " + year + " " + bodyType);
        }
    }
}
