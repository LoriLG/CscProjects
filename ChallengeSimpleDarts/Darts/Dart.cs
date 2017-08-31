using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
      

        public int Score { get; set; }
        public bool IsDoubleBand { get; set; }
        public bool IsTripleBand { get; set; }
        public bool IsOuterBullsEye {get;set;}

        private Random _random;

        public Dart(Random random)
        {
            _random = random;
        }

        public void Throw()
        {
           Score = _random.Next(0, 21);
           if (Score == 0)
                IsOuterBullsEye = true;

           int multiplier = _random.Next(1, 101);
           if (multiplier > 95)
                 IsTripleBand = true;
           else if (multiplier > 90)
                 IsDoubleBand = true; 

        }
            
    }
}

