using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double total;
            if (babyBobRadioButton.Checked)
                total = 10.00;
            else if (mamaBobRadioButton.Checked)
                total = 13.00;
            else
                total = 16.00;
            if (deepDishRadioButton.Checked)
                total = total + 2.00;
            if (pepperoniCheckBox.Checked)
                total = total + 1.50;
            if (onionsCheckBox.Checked)
                total += 0.75;
            total = (greenPeppersCheckBox.Checked) ? total + 0.50 : total;
            total = (redPeppersCheckBox.Checked) ? total + 0.75 : total;
            total = (anchoviesCheckBox.Checked) ? total + 2.00 : total;

            if ((pepperoniCheckBox.Checked && greenPeppersCheckBox.Checked && anchoviesCheckBox.Checked)
                || (pepperoniCheckBox.Checked && redPeppersCheckBox.Checked && onionsCheckBox.Checked))
                total = total - 2.00;

            resultLabel.Text = "$" + total.ToString();




        }
    }
}