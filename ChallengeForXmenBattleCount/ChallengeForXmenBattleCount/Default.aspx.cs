using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";
           
           int MostBattlesIndex = 0;
           int LeastBattlesIndex = 0;

            
            for (int i = 0; i < names.Length; i++)
                   {

                      if (numbers[i] > numbers[MostBattlesIndex])
                            MostBattlesIndex = i;

                      if (numbers[i] < numbers[LeastBattlesIndex])
                            LeastBattlesIndex = i;

                      }

                result = String.Format("Most battles belong to: {0} (value: {1})<br/>", names[MostBattlesIndex], numbers[MostBattlesIndex]);
                result += String.Format("Least battles belong to: {0} (Value: {1})", names[LeastBattlesIndex], numbers[LeastBattlesIndex]); 

               resultLabel.Text = result;


            }
        }
    }

