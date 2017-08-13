using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstValueTextBox.Text);
            double second = double.Parse(secondValueTextBox.Text);
            double result = first + second;
            resultLabel.Text = result.ToString();
     /* Could decrease one line--> resultLabel.Text = (first + second).ToString();
       Remove double result = first + second. */

        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstValueTextBox.Text);
            double second = double.Parse(secondValueTextBox.Text);
            double result = first - second;
            resultLabel.Text = result.ToString();

        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstValueTextBox.Text);
            double second = double.Parse(secondValueTextBox.Text);
            double result = first * second;
            resultLabel.Text = result.ToString();

        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstValueTextBox.Text);
            double second = double.Parse(secondValueTextBox.Text);
            double result = first / second;
            resultLabel.Text = result.ToString();

           

        }
    }
}