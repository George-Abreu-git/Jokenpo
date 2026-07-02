using System;
using System.Dynamic;

namespace Jokenpo.Models
{
    public class Tournament
    {



        public static void Start()
        {
            string[] players = GetPlayers.GetNameOfPlayers();



            while (players.Length > 1)
            {

                players = PairsDraw.PairsRandom(players);
                string[][] pairs = PairsDraw.CreatePairs(players);
                string[] winners = RunRound(pairs);

                players = winners;

            }


            Console.WriteLine($"O campeão é {players[0]}");

        }


        //Executa rodadas a partir de Match
        private static string[] RunRound(string[][] pairs)
        {
            //atribui o tamanho de pairs em winners
            string[] winners = new string[pairs.Length];

            for (int i = 0; i < pairs.Length; i++)
            {
                winners[i] = Match(pairs[i]);
            }

            return winners;
        }

        //Executa apenas 1 Match entre 2 jogadores
        private static string Match(string[] pair)
        {
            //player1 e jogador 2 recebem 0 e 1 da lista de par
            string player1 = pair[0];
            string player2 = pair[1];

            int move1 = 0;
            int move2 = 0;
            int result = 0;

            //enquanto result for empate repete jogadas
            while (result == 0)
            {
                move1 = Play.RandomPlay();
                move2 = Play.RandomPlay();

                result = Play.DetermineWinner(move1, move2);
            }

            if (result == move1)
            {
                return player1;
            }
            else
            {
                return player2;
            }

        }

    }


}
