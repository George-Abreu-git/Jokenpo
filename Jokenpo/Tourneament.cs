using System;

namespace Jokenpo
{
    public class Tourneament
    {

        

        public static void Start()
        {
            string [] players = GetPlayers.GetNameOfPlayers();

            while(players.Length > 1)
            {
                string[] rndPlayers = PairsDraw.PairsRandom(players);
                string[][] pairs = PairsDraw.CreatePairs(rndPlayers);
                
            }

            
        }

       
        
    }

    
}
