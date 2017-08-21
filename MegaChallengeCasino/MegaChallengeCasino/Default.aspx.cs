using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeCasino
{
    public partial class Default : System.Web.UI.Page
    {
      Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            
           if (!Page.IsPostBack)
            {
                ViewState.Add("PlayersMoney", 100);
                displayPlayersMoney();
            }

         }

        private void displayPlayersMoney()
        {
           moneyLabel.Text = String.Format("Player's Money: {0:C}", ViewState["PlayersMoney"]);
        } 

        protected void yourBetTextBox_TextChanged(object sender, EventArgs e)
        {
            

        }


        protected void okButton_Click(object sender, EventArgs e)
        {
            //Creating 3 random images that change when Pull The Lever button clicked.
           string[] imageNames = {"Bar.png", "Bell.png", "Cherry.png", "Clover.png", "Diamond.png", "HorseShoe.png",
                "Lemon.png","Orange.png", "Plum.png", "Seven.png", "Strawberry.png","Watermelon.png"};
            int i = random.Next(0, imageNames.Length - 1);
            int j = random.Next(0, imageNames.Length - 1);
            int k = random.Next(0, imageNames.Length - 1);
            firstImage.ImageUrl = "~/" + imageNames[i];
            secondImage.ImageUrl = "~/" + imageNames[j];
            thirdImage.ImageUrl = "~/" + imageNames[k];



            int x = calculateCherryCount(imageNames[i], imageNames[j], imageNames[k]);
            int y = calculateSevenCount(imageNames[i], imageNames[j], imageNames[k]);
            int z = calculateBarCount(imageNames[i], imageNames[j], imageNames[k]);

            int bet = 0;

            if (!int.TryParse(yourBetTextBox.Text, out bet))
                return;
            if (yourBetTextBox.Text.Trim().Length == 0)
                return; 


            int totalMultiplier = calculateMultiplier(x, y, z);
            int totalWin = pullever(bet, totalMultiplier);

            displayResult(bet, totalWin);

            calculateplayersTotal(bet, totalWin);
            displayPlayersMoney();

        }
       
        private int pullever( int bet, int totalMultiplier )
        {  

         int totalWin = 0;
            if (bet >= 1)
                totalWin = bet * totalMultiplier;
            else
                totalWin = 0;
            
          return totalWin; 
    }

       private void displayResult(int bet, int totalWin)
        {
            if (totalWin > 0)
            
                resultLabel.Text = String.Format("You bet {0:C} and Won {1:C}!", yourBetTextBox.Text, totalWin);
            else
                resultLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time.", bet);

            
        } 


        //Calculate Cherry count

        private int calculateCherryCount(string firstImage, string secondImage, string thirdImage)
        {

            int totalCherries = 0;
            if (firstImage == "Cherry.png")
                totalCherries += 1;

            if (secondImage == "Cherry.png")
                totalCherries += 1;

            if (thirdImage == "Cherry.png")
                totalCherries += 1;

            return totalCherries;
        }

        //Calculate Seven count

        private int calculateSevenCount(string firstImage, string secondImage, string thirdImage)
        {
            int totalSevens = 0;
            if (firstImage == "Seven.png")
                totalSevens += 1;
            if (secondImage == "Seven.png")
                totalSevens += 1;
            if (thirdImage == "Seven.png")
                totalSevens += 1;

            return totalSevens;

        }

        //Calculate Bar count
        private int calculateBarCount(string firstImage, string secondImage, string thirdImage)
        {
            int totalBars = 0;
            if (firstImage == "Bar.png")
                totalBars += 1;
            if (secondImage == "Bar.png")
                totalBars += 1;
            if (thirdImage == "Bar.png")
                totalBars += 1;

            return totalBars;
        }

        //Calculate Multiplier

        private int calculateMultiplier(int x, int y, int z)

        {
            int totalMultiplier = 0;
            if (x == 1)
               totalMultiplier = 2;
            if (x == 2)
               totalMultiplier = 3;
            if (x == 3)
               totalMultiplier = 4;
            if (y == 3)
               totalMultiplier = 100;
            if (z >= 1)
                totalMultiplier = 0;
            return totalMultiplier;
          }

    //Calculate Total players Money after winnings and losses

   


    private void calculateplayersTotal (int bet, int totalWin)

        {

            int playersMoney = int.Parse(ViewState["PlayersMoney"].ToString());
            playersMoney -= bet;
            playersMoney += totalWin;
            ViewState["PlayersMoney"] = playersMoney;
           

        }
    }
 }
