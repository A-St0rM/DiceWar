using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWar
{
    public class Dice
    {
        public int Value { get; set; }

        public void Roll() {
            System.Random rng = new Pcg.PcgRandom();
            Value = rng.Next(1, 7);
        }

        public virtual int Point() {
            return Value;
        }

        
        public override String ToString() //override
        {
            return "[" + Value + "] ";
        }



    }
}
