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
    public partial class Vehicles : Form
    {
        public Vehicles ()
        {
            InitializeComponent();
        }

        public Vehicles(List<string> SelectedItem)
        {
            InitializeComponent();

            //Read in data from each file to populate vehicles page with vehicles;
            //If selected item is equal to value, begin loop;
            if (SelectedItem[0] == "London")

            {   //Read in data from location file into an array;
                string[] londonData = File.ReadAllLines("Vehicles/Location1.csv");

                //Whilst the current index position is less than the length of the file, iterate forward;
                for (int i = 0; i < londonData.Length; i++)
                {
                    //Split the data in the files by commas and put into a new array called bits;
                    string[] bits = londonData[i].Split(',');

                    //if the length of bits is NOT equal to one, add to UI list box;
                    if (bits.Length != 1)
                    {
                        vehiclesListBox.Items.Add(londonData[i]);
                                               
                    }

                    //Else, continue to iterate through;
                    else
                    {
                        continue;
                    }

                }
            }
            if (SelectedItem[0] == "Lisbon")
            {
                string[] lisbonData = File.ReadAllLines("Vehicles/Location2.csv");
                for (int i = 0; i < lisbonData.Length; i++)
                {
                    string[] bits = lisbonData[i].Split(',');

                    if (bits.Length != 1)
                    {
                        vehiclesListBox.Items.Add(lisbonData[i]);
                    }
                    else
                    {
                        continue;
                    }

                }
            }
            if (SelectedItem[0] == "Tokyo")
            {
                string[] tokyoData = File.ReadAllLines("Vehicles/Location3.csv");
                for (int i = 0; i < tokyoData.Length; i++)
                {
                    string[] bits = tokyoData[i].Split(',');

                    if (bits.Length != 1)
                    {
                        vehiclesListBox.Items.Add(tokyoData[i]);
                    }
                    else
                    {
                        continue;
                    }

                }
            }
            if (SelectedItem[0] == "Paris")
            {
                string[] parisData = File.ReadAllLines("Vehicles/Location4.csv");
                for (int i = 0; i < parisData.Length; i++)
                {
                    string[] bits = parisData[i].Split(',');

                    if (bits.Length != 1)
                    {
                        vehiclesListBox.Items.Add(parisData[i]);
                    }
                    else
                    {
                        continue;
                    }

                }
            }



        }

        private void add_Click(object sender, EventArgs e)
        {
            //Upon clicking add, vehicle form will appear;
            Form myform = new Vehicle();
            myform.Show();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            //Upon clicking modify, vehicle form will appear;
            Form myform = new Vehicle();
            myform.Show();
        }

        private void VehiclesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    


}
