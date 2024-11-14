using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWar
{
    public class WarDiceCup
    {


        WarDice[] dices;

        public WarDiceCup(int numberOfDices)
        {
            dices = new WarDice[numberOfDices];
            for (int i = 0; i < numberOfDices; i++)
            {
                dices[i] = new WarDice();
            }
            
        }

        public void RollAll()
        {

            foreach (WarDice d in dices)
            {
                d.Roll();
            }

        }

        public int SumPoint()
        {
            int result = 0;
            foreach (WarDice d in dices)
            {
                result += d.Point();
                
            }
            return result;

        }

        public override String ToString() {
            String result = "";
            foreach (WarDice d in dices)
            {
                result += d.ToString();
            }
            return result;

        }
    }
}
