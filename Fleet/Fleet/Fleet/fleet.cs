using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fleet
{
    public partial class fleetForm : Form
    {
        private int numItems;
        private static int arrayMax;
        private Vehicle[] vehicles;

        public fleetForm()
        {
            InitializeComponent();
            numItems = 0;
            arrayMax = 10;
            // Create an array of type Vehicle with size 10, (use a static variable for the array size)
            vehicles = new Vehicle[arrayMax];
        }

        // Airplane Add Button
        private void btnAddAirplane_Click(object sender, EventArgs e)
        {
            try
            {
                if (numItems == arrayMax)
                {
                    MessageBox.Show("Vehicle List is full");
                    return;
                }
                else
                {
                    // create a new Airplane object, pass through textbox text, add object to array
                    Airplane a = new Airplane();
                    a.setMake(tbMake.Text);
                    a.setModel(tbModel.Text);
                    a.setYear(int.Parse(tbYear.Text));
                    a.setNoEgines(int.Parse(tbAirplaneNumEngines.Text));
                    a.setEngineType(tbAirplaneEngineType.Text);
                    vehicles[numItems] = a;

                    // increase numItem so the next new vehcile can be created
                    numItems++;

                    // clear textboxes
                    Clear();

                    // display vehicles
                    DisplayVehicles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex, "Exception Throw", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Airplane Overload Button
        private void btnOverloadAirplane_Click(object sender, EventArgs e)
        {
            try
            {
                if (numItems == arrayMax)
                {
                    MessageBox.Show("Vehcile List is full");
                    return;
                }
                else
                {
                    // create a new Airplane object using the Overloaded constructor, pass through textbox text, add object to array
                    Airplane a = new Airplane(tbMake.Text, tbModel.Text, int.Parse(tbYear.Text), int.Parse(tbAirplaneNumEngines.Text), tbAirplaneEngineType.Text);
                    vehicles[numItems] = a;

                    // increase numItem so the next new vehcile can be created
                    numItems++;

                    // clear textboxes
                    Clear();

                    // display vehicles
                    DisplayVehicles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex, "Exception Throw", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        // Boat Add Button
        private void btnAddBoat_Click(object sender, EventArgs e)
        {
            try
            {
                if (numItems == arrayMax)
                {
                    MessageBox.Show("Vehcile List is full");
                    return;
                }
                else
                {
                    // create a new Boat object, pass through textbox text, add object to array
                    Boat b = new Boat();
                    b.setMake(tbMake.Text);
                    b.setModel(tbModel.Text);
                    b.setYear(int.Parse(tbYear.Text));
                    b.setLength(tbBoatLength.Text);
                    b.setHullType(tbBoatHullType.Text);
                    vehicles[numItems] = b;

                    // increase numItem so the next new vehcile can be created
                    numItems++;

                    // clear textboxes
                    Clear();

                    // display vehicles
                    DisplayVehicles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex, "Exception Throw", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Boat Overload Button
        private void btnOverloadBoat_Click(object sender, EventArgs e)
        {
            try
            {
                if (numItems == arrayMax)
                {
                    MessageBox.Show("Vehcile List is full");
                    return;
                }
                else
                {
                    // create a new Boat object using the Overloaded constructor, pass through textbox text, add object to array
                    Boat b = new Boat(tbMake.Text, tbModel.Text, int.Parse(tbYear.Text), tbBoatLength.Text, tbBoatHullType.Text);
                    vehicles[numItems] = b;

                    // increase numItem so the next new vehcile can be created
                    numItems++;

                    // clear textboxes
                    Clear();

                    // display vehicles
                    DisplayVehicles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex, "Exception Throw", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Car Add Button
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (numItems == arrayMax)
                {
                    MessageBox.Show("Vehcile List is full");
                    return;
                }
                else
                {
                    // create a new Car object, pass through textbox text, add object to array
                    Car c = new Car();
                    c.setMake(tbMake.Text);
                    c.setModel(tbModel.Text);
                    c.setYear(int.Parse(tbYear.Text));
                    c.setBodyType(tbCarBodyType.Text);
                    vehicles[numItems] = c;

                    // increase numItem so the next new vehcile can be created
                    numItems++;

                    // clear textboxes
                    Clear();

                    // display vehicles
                    DisplayVehicles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex, "Exception Throw", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnOverloadCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (numItems == arrayMax)
                {
                    MessageBox.Show("Vehcile List is full");
                    return;
                }
                else
                {
                    // create a new Car object using the Overloaded constructor, pass through textbox text, add object to array
                    Car c = new Car(tbMake.Text, tbModel.Text, int.Parse(tbYear.Text), tbCarBodyType.Text);
                    vehicles[numItems] = c;

                    // increase numItem so the next new vehcile can be created
                    numItems++;

                    // clear textboxes
                    Clear();

                    // display vehicles
                    DisplayVehicles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex, "Exception Throw", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // method to clear all textboxes
        public void Clear()
        {
            tbMake.Clear();
            tbModel.Clear();
            tbYear.Clear();
            tbAirplaneEngineType.Clear();
            tbAirplaneNumEngines.Clear();
            tbBoatLength.Clear();
            tbBoatHullType.Clear();
            tbCarBodyType.Clear();
        }

        // method to display vehicles array to listbox
        public void DisplayVehicles()
        {
            lstOutput.Items.Clear();
            for (int i = 0; i < numItems; i++)
            {
                // display vehicles array in lstOutput
                //lstOutput.Items.Add(books[i].getAuthor() + ", " + books[i].getAuthor() + ". " + books[i].getDate() + ". " + books[i].getPublisher());
                lstOutput.Items.Add(vehicles[i].Display());
            }
        }
    }
}
