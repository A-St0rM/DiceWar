using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWar
{
    public class Game
    {

        WarDiceCup player;
        WarDiceCup computer;

        private int player1Score;
        private int computerScore;
        private int rounds;



        public void StartGame(int numberOfDicees, int rounds)
        {

            player = new WarDiceCup(numberOfDicees);
            computer = new WarDiceCup(numberOfDicees);

            for (int i = 1; i < rounds; i++)
            {
                Console.WriteLine(" --- Round --- " + i);
                PlayRound();
            }


        }

        public void PlayRound() {

            player.RollAll();
            computer.RollAll();

            int player1Points = player.SumPoint();
            int computerPoints = computer.SumPoint();

            Console.WriteLine("Player " + player.ToString() + " Total Points " +  player1Points);
            Console.WriteLine("Computer " + computer.ToString() + " Total Points " + computerPoints);


        }

       



    }
}
