using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {

            // CHALLENGE 1:  Reversing the order of my name. ( I found 2 different methods)

            // Method 1:
             string input = "Lori Gross";
             char[] inputarray = input.ToCharArray();

             Array.Reverse(inputarray);
             string output = new string(inputarray);

              resultLabel.Text = output; 

            // Method 2:

             string input1 = "Lori Gross";
             string output1 = "";
             for (int i= input1.Length-1; i >= 0; i--)
             {
                 output1 += input1[i];

                 resultLabel.Text = output1;  
             } 
              


            //CHALLENGE 2: Reverse this Sequence of names.
             string names =  "Luke, Leia, Han, Chewbacca" ;
             string[] initialNames = names.Split(',');
             string finalResult = "";

               for (int i = initialNames.Length - 1; i >= 0; i--)
               {

                   finalResult += initialNames[i] + ", ";
               }
               finalResult = finalResult.Remove(finalResult.Length - 2, 1);
               resultLabel.Text = finalResult;  



            //CHALLENGE 3:  Use the sequence to create ascii art:
            // *****Luke*****
            // *****Leia*****
            // *****Han******
            // **Chewbacca***

               string names1 = "Luke,Leia,Han,Chewbacca";
               string[] finalNames = names1.Split(',');
               string result = "";

               for (int i = 0; i < finalNames.Length; i++)
               {
                   int padLeft = (14 - finalNames[i].Length) / 2;
                   string left = finalNames[i].PadLeft(finalNames[i].Length + padLeft, '*');
                   result += left.PadRight(14, '*');
                   result += " <br />";

               }

               resultLabel.Text = result; 


            // CHALLENGE 4: Solve this puzzle:

        string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.
           
            resultLabel.Text = puzzle.Replace('Z', 't').ToLower().Replace("now", "Now").Remove(10, 9); 

        }
    }
 }


