using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWar
{
    class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame(3, 3);
        }
    }
}
