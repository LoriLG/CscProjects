using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                previousEndDateCalendar.SelectedDate = DateTime.Now.Date;
            if (!Page.IsPostBack)
                newStartDateCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
            if (!Page.IsPostBack)
                projectedEndDateCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            Page.MaintainScrollPositionOnPostBack = true;
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            double budget = (projectedEndDateCalendar.SelectedDate.Subtract(newStartDateCalendar.SelectedDate).TotalDays);
            if (projectedEndDateCalendar.SelectedDate.Subtract(newStartDateCalendar.SelectedDate).TotalDays >= 1)
                budget = budget * 500;
            if (projectedEndDateCalendar.SelectedDate.Subtract(newStartDateCalendar.SelectedDate).TotalDays > 21)
                budget = budget + 1000;

            String result = String.Format("Assignment of {0} to assignment {1} is authorized. " +
            "Budget total: {2:C}", codeNameTextBox.Text, assignmentNameTextBox.Text, budget);
            resultLabel.Text = result;

            if (newStartDateCalendar.SelectedDate.Subtract(previousEndDateCalendar.SelectedDate).TotalDays < 14)
            {
                result = "Error: Must allow at least two weeks between previous assignment and new assignment.";
                resultLabel.Text = result;
            }

            DateTime earliestNewAssignment = previousEndDateCalendar.SelectedDate.AddDays(14);
            newStartDateCalendar.SelectedDate = earliestNewAssignment;
            newStartDateCalendar.VisibleDate = earliestNewAssignment;
        }
    }
  }
