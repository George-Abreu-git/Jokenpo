using System;
using System.Dynamic;

namespace Jokenpo.Models
{
    public class Tourneament
    {

        

        public static string []Start()
        {
            string [] players = GetPlayers.GetNameOfPlayers();
            
            

            while(players.Length > 1)
            {
                string[] rndPlayers = PairsDraw.PairsRandom(players);
                
                string [] winner = [];

                Partida(rndPlayers);


            }

            return players;
            
        }


        public static int Partida (string [][] pairs)
        {
            int ganhador = 0;
            int move1 = 0;
            int move2 = 0;
            
            foreach(string []pair in pairs)
            {
                while (Play.DetermineWinner(move1, move2) == 0)
            {
                move1 = Play.RandomPlay();
                move2 = Play.RandomPlay();
                
                ganhador = Play.DetermineWinner(move1,move2);
            }
            return ganhador;
            }
            
            return ganhador;
        }


        // public static string []JogadaJogador(string [][]pairs)
        // {
        //     for []
        // }

    }

    
}
