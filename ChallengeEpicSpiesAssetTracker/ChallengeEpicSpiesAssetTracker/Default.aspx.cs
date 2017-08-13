using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
     
        {
            if (!Page.IsPostBack)
            {
                string[] asset = new string[0];
                ViewState.Add("Asset", asset);
                int[] elections = new int[0];
                ViewState.Add("Elections", elections);
                double[] subterfuge = new double[0];
                ViewState.Add("Subterfuge", subterfuge);
            }

        }


        protected void okButton_Click(object sender, EventArgs e)
        {

            string[] asset = (string[])ViewState["Asset"];
            int[] elections = (int[])ViewState["Elections"];
            double[] subterfuge = (double[])ViewState["Subterfuge"];

            int newLength = asset.Length + 1;
            Array.Resize(ref asset, newLength);
            Array.Resize(ref elections, newLength);
            Array.Resize(ref subterfuge, newLength);

            int newIndex = asset.GetUpperBound(0);

            asset[newIndex] = assetNameTextBox.Text;
            elections[newIndex] = int.Parse(electionsRiggedTextBox.Text);
            subterfuge[newIndex] = double.Parse(actsOfSubterfugeTextBox.Text);

            ViewState["Asset"] = asset;
            ViewState["Elections"] = elections;
            ViewState["Subterfuge"] = subterfuge;

           
           
            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br />Average Acts of subterfuge per Asset: {1:N2}<br />(Last Asset you Added: {2} ) ",
                elections.Sum(),
                subterfuge.Average(),
                asset [newIndex]);

            assetNameTextBox.Text = "";
            electionsRiggedTextBox.Text = "";
            actsOfSubterfugeTextBox.Text = "";



           
        }
    }
}