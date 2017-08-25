using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {




        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Hercules";
            hero.Health = 100;
            hero.DamageMaximum = 30;
            hero.AttackBonus = 0;
            Character monster = new Character();
            monster.Name = "Cyclops";
            monster.Health = 100;
            monster.DamageMaximum = 20;
            monster.AttackBonus = 0;

            int finalMonster = monster.Defend(hero.Attack());
            int finalHero = hero.Defend(monster.Attack());

            

            resultLabel.Text = String.Format(" {0}: Health {2}, DamageMaximum {4}, AttackBonus {6}" +
                "<br/>" + "{1}: Health {3}, DamageMaximum {5}, AttackBonus {7}",
                hero.Name, monster.Name, finalHero, finalMonster, 
                hero.DamageMaximum, monster.DamageMaximum,
                hero.AttackBonus, monster.AttackBonus);

        }

    }


    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public int AttackBonus { get; set; }



        public int Attack()
        {
            Random random = new Random();
            int damage = random.Next(DamageMaximum);
            return damage;

        }

        public int Defend(int damage)
        {
            Health -= damage;
            return Health;
        }

     }
}



