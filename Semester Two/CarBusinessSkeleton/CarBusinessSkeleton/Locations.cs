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
    public partial class Locations : Form
    {
        public Locations()
        {
            InitializeComponent();
        }

        public Locations(List<string> Vehicles)
        {
            InitializeComponent();

            string[] VehiclesOnly = new string[Vehicles.Count];

            for (int i = 0; i < Vehicles.Count; i++)
            {

                string[] bits = Vehicles[i].Split(',');

                if (bits.Length == 1)
                {
                    locationsList.Items.Add(Vehicles[i]);
                }
                else
                {
                    VehiclesOnly[i] = Vehicles[i];
                    continue;
                }
            }

        }

        private void selectLocation_Click(object sender, EventArgs e)
        {
            //Upon clicking select, the next form that will appear will correspond to the item selected;
            Form myForm = new Vehicles(SelectedItem);


            myForm.Show();

        }

        public List<string> SelectedItem = new List<string>();



        private void LocationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLocation = locationsList.SelectedItem.ToString();
            SelectedItem.Add(selectedLocation);

        }

        private void VehiclesInStock_Click(object sender, EventArgs e)
        {

        }

        private void TotalValue_Click(object sender, EventArgs e)
        {

        }

        private void MostExpensive_Click(object sender, EventArgs e)
        {

        }

        private void MostExpensiveType_Click(object sender, EventArgs e)
        {

        }
    }
}
