using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Score
    {
        public static void ScoreDart(Player player, Dart dart)
        {
            int score = 0;

            if (dart.IsTripleBand)
                score = dart.Score * 3;
            else if (dart.IsDoubleBand)
                score = dart.Score * 2;
            else if (dart.IsOuterBullsEye)
                score = 25;
            else score = dart.Score;


            if (dart.IsTripleBand && dart.Score == 0)
                score = 50;
            //else if (dart.Score == 0)
              // score = 25;

            
            player.Score += score;

        }
    }
}