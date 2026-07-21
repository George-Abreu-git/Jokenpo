using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokenpo.Models
{
    public class PlayerBot : Player
    {

        private static Random numRandom = new Random();
        public PlayerBot(string name) : base(name)
        {
            
        }

        public override int PlayerMove()
        {
            return numRandom.Next(1,4);
        }

        // public static List<Player> SetPlayersName(int quantity)
        // {
        //     //quantity = InputQuantity
        //     List<Player> playersName = new List<Player>();
        //     int playerNumber = 0;

        //     for(int i = 0; i < quantity; i++)
        //     {
        //         playerNumber = i + 1;
        //        playersName.Add(new PlayerBot($"Player {playerNumber}"));
        //     }

        //     return playersName; 
        // }
    }
}