using System;
using System.Dynamic;

namespace Jokenpo.Models
{
    public class Tourneament
    {

        

        public static void Start()
        {
            string [] players = GetPlayers.GetNameOfPlayers();
            
            

            while(players.Length > 1)
            {
                
                players = PairsDraw.PairsRandom(players);
                string[][] pairs = PairsDraw.CreatePairs(players);
                string[] winners = JogarRodadas(pairs);

                players = winners;

            }
            

            Console.WriteLine($"Campeão é {players}");
            
        }



    }

    
}
