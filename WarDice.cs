using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWar
{
    public class WarDice : Dice
    {

        public WarDice()
        {

        }

        public override int Point() 
        {
            if (Value % 2 != 0)
            { // if the value is odd

                return Value*2;

            }
                return Value;
            
        }



    }
}
