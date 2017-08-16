using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
       protected void Page_Load(object sender, EventArgs e)

        {
            
        }
       
        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
          

        }

        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            
           
        } 

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            calculateTotalCost(.15);
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            calculateTotalCost(.25);
        }

        protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            calculateTotalCost(.45);
        }
        
       
        private void calculateTotalCost(double shippingRatio)
       // private void calculateTotalCost()

        {

            if (widthTextBox.Text.Trim().Length == 0)
                return;
            if (heightTextBox.Text.Trim().Length == 0)
                return;

            double dimensions = 0.0;
            double width = 0.0;
            double height = 0.0;
            double length = 0.0;

            if (!Double.TryParse(widthTextBox.Text, out width))
                return;

            if (!Double.TryParse(heightTextBox.Text, out height))
                return;
            if (!Double.TryParse(lengthTextBox.Text, out length)) 
                length = 1;


            dimensions = width * height * length;
        
            double cost = dimensions * shippingRatio;

             

           /*if (groundRadioButton.Checked) cost = dimensions * .15;
            else if (airRadioButton.Checked) cost = dimensions * .25;
            else if (nextDayRadioButton.Checked) cost = dimensions * .45; */

            resultLabel.Text = String.Format ("Your parcel will cost {0:C} to ship.", cost);
        }
    }
}