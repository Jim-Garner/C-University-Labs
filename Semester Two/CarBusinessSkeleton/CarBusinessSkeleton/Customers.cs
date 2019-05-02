using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBusinessSkeleton
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();

        }

        public Customers(List<string> customerVehicles)
        {
            InitializeComponent();

            string[] VehiclesOnly = new string[customerVehicles.Count];
            decimal priceTotal;

            for (int i = 0; i < customerVehicles.Count; i++)
            {

                string[] bits = customerVehicles[i].Split(',');

                if (bits.Length == 1)
                {
                    customerListBox1.Items.Add(customerVehicles[i]);
                }
                if (bits.Length != 1)
                {
                    priceTotal = decimal.Parse(bits[4]);
                    priceTotal = priceTotal + priceTotal;
                    

                }
                else
                {
                    VehiclesOnly[i] = customerVehicles[i];
                    continue;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form myform = new Vehicle();
            myform.Show();
        }

        private void CustomerListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VehiclesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
