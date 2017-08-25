using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Hercules";
            hero.Health = 35;
            hero.DamageMaximum = 20;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Cyclops";
            monster.Health = 21;
            monster.DamageMaximum = 25;
            monster.AttackBonus = true;

            Dice number = new Dice();

      

            if (hero.AttackBonus)
                monster.Defend(hero.Attack(number));
            if (monster.AttackBonus)
                hero.Defend(monster.Attack(number));

            while (hero.Health > 0 && monster.Health > 0)
            {
                monster.Defend(hero.Attack(number));
                hero.Defend(monster.Attack(number));

                printStats(hero);
                printStats(monster);


            }

            displayResult(hero, monster);
        }

        private void printStats(Character character)

        {
            resultLabel.Text += String.Format("<p> {0} - Health: {1},  DamageMaximum: {2}, AttackBonus: {3}</p>",
                character.Name, character.Health, character.DamageMaximum,
                character.AttackBonus);
        }

        private void displayResult(Character opponent1, Character opponent2)

           {
            if (opponent1.Health <= 0 && opponent2.Health <= 0)
                resultLabel.Text += string.Format("<br/> Both {0} and the {1} died.", opponent1.Name, opponent2.Name);
            else if(opponent1.Health <= 0)
                resultLabel.Text += string.Format("<br/>{0} defeats {1}.", opponent2.Name, opponent1.Name);
           else if (opponent2.Health <= 0)
                resultLabel.Text += string.Format("<br/>{0} defeats the {1}", opponent1.Name, opponent2.Name);
          
           }

    }
     
    
        class Character
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMaximum { get; set; }
            public bool AttackBonus { get; set; }

            public int Attack(Dice number)
            {
                number.Sides = this.DamageMaximum;
                return number.Roll();
            }


            public void Defend(int damage)
            {
                
                this.Health -= damage;
            }
        }
        class Dice
        {

            Random random = new Random();
            public int Sides { get; set; }

              public int Roll()
            {

            return random.Next(this.Sides);
             
            }
        }
}

