using System;

namespace Jokenpo
{
    public class PairsDraw
    {
        public static string[][] PairsStart()
        {
            string[] players = GetPlayers.GetNameOfPlayers();
            string[] rndPlayers = PairsRandom(players);
            string[][] pairs = CreatePairs(rndPlayers);
            


            return pairs;
        }



        private static string[][] CreatePairs(string[] players)
        {
            int pairCount = players.Length / 2;
            string[][] pairs = new string[pairCount][];

            int index = 0;

            for (int i = 0; i < pairCount; i++)
            {
                pairs[i] = new string[2];
                pairs[i][0] = players[index++];
                pairs[i][1] = players[index++];
            }

            return pairs;
        }

        private static readonly Random _random = new Random();

        private static string [] PairsRandom(string[] players)
        {
            
           
            for (int i = players.Length - 1; i >= 0; i--)
            {
                int randomIndex = _random.Next(i+1);
                
                string temp = players[i];
                players[i] = players[randomIndex];
                players[randomIndex] = temp;
            }

            return players;
        }

       
    }
}
