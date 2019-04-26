using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNum = double.Parse(firstNumber.Text); double secondNum = double.Parse(secondNumber.Text);

                result.Text = (firstNum + secondNum).ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter a number.");
            }

        }

        private void FirstNum_TextChanged(object sender, EventArgs e)
        {

        }
        private void SecondNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNum = double.Parse(firstNumber.Text); double secondNum = double.Parse(secondNumber.Text);

                result.Text = (firstNum - secondNum).ToString();
            }

            catch
            {
                MessageBox.Show("Invalid input. Please enter a number.");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNum = double.Parse(firstNumber.Text); double secondNum = double.Parse(secondNumber.Text);

                result.Text = (firstNum * secondNum).ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter a number.");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNum = double.Parse(firstNumber.Text); double secondNum = double.Parse(secondNumber.Text);

                result.Text = (firstNum / secondNum).ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter a number.");
            }
        }

    }
}
