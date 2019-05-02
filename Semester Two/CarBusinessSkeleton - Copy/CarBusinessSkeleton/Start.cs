using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CarBusinessSkeleton
{
    public partial class Start : Form
    {
        public List<string> Vehicles = new List<string>();
        public List<string> customerVehicles = new List<string>();

        public Start()
        {
            InitializeComponent();
            ReadInData();
        }

        private void Business_Click(object sender, EventArgs e)
        {
            Form myForm = new Locations(Vehicles);
            myForm.Show();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            Form myForm = new Customers(customerVehicles);
            myForm.Show();
        }

        public void ReadInData()
        {
            //Business side vehicle data;

            string[] londonData = File.ReadAllLines("Vehicles/Location1.csv");
            Vehicles.AddRange(londonData);

            string[] lisbonData = File.ReadAllLines("Vehicles/Location2.csv");
            Vehicles.AddRange(lisbonData);

            string[] tokyoData = File.ReadAllLines("Vehicles/Location3.csv");
            Vehicles.AddRange(tokyoData);

            string[] parisData = File.ReadAllLines("Vehicles/Location4.csv");
            Vehicles.AddRange(parisData);

            //Customer data;

            string[] customerData = File.ReadAllLines("Customer.csv");
            customerVehicles.AddRange(customerData);
        }

    }
}
