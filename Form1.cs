// Ahmed Benyusuf
// Class and Section (CS 313 01)
// Assignment (Program 01 Chapter 06)
// Description of the Program: this program will calculate the retail cost based off of the
// wholesale cost as well as check if the wholesale cost is 0 or less and if the markup is under 2%.
// Extra credit : I added a check for if the markup is under 2% / 0.02 and if the wholesale cost is 0 or less.




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C06_P01
{
    public partial class CostCalculator : Form
    {
        public CostCalculator()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double TotalCost = 0, WholsaleCost = 0, Markup = 0; // declare variables

            double.TryParse(WholsaleCostTextbox.Text, out WholsaleCost);
            double.TryParse(MarkupTextbox.Text, out Markup);
            // Converts text input into doubles

            Markup = Markup / 100; // convert markup to percentage

            // calculate total cost
            TotalCost = WholsaleCost * Markup + WholsaleCost;
            OutputLabel.Text = TotalCost.ToString("c");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            // closes the form
        }

        private void CostCheckButton_Click(object sender, EventArgs e)
        {
            double WholsaleCost = 0;// declare variable

            double.TryParse(WholsaleCostTextbox.Text, out WholsaleCost);
            // Converts text input into doubles
            if (WholsaleCost <= 0)
            // check if wholesale cost is 0 or less
            {
                CostCheckLabel.Text = ("Wholesale cost 0 or less.");
            }
            else 
                CostCheckLabel.Text = ("true");
            // if wholesale cost is greater than 0 returns true

        }

        private void MarkupCheckButton_Click(object sender, EventArgs e)
        {
            double Markup = 0; // declare variable

            double.TryParse(MarkupTextbox.Text, out Markup);
            // Converts text input into doubles

            Markup = Markup / 100; // convert markup to percentage
            
            if (Markup <= 0.02)
            {
                MarkupCheckLabel.Text = ("Markup under 2%.");
            }
            else
                MarkupCheckLabel.Text = ("true");
            // if markup is greater than 2% returns true


        }
    }
}
