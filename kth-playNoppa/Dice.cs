using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kth_playNoppa
{
    internal class Dice
    {
        //Random num property
        public int Value;
        //Dice constructor
        public Dice()
        {
            Value = 0;
        }
        //Dice roll
        public void Roll(Random rng)
        {
            Value = rng.Next(1, 6 + 1);
        }
    }
}
