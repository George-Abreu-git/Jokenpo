using System;
using System.Dynamic;
using System.Reflection.PortableExecutable;

namespace Jokenpo.Models
{
    public class Tournament
    {



        public static void Start()
        {
            string[] players = GetPlayers.GetNameOfPlayers();
            int rounds = GetRounds.SetRounds();



            while (players.Length > 1)
            {

                players = PairsDraw.PairsRandom(players);
                string[][] pairs = PairsDraw.CreatePairs(players);
                string[] winners = RunRound(pairs, rounds);

                players = winners;


            }


            Console.WriteLine($"O campeão é {players[0]}");

        }


        //Executa rodadas a partir de Match
        private static string[] RunRound(string[][] pairs, int rounds)
        {
            //atribui o tamanho de pairs em winners
            string[] winners = new string[pairs.Length];
            //int victoryPlayer1 = 0;
            //int victoryPlayer2 = 0;



            for (int i = 0; i < pairs.Length; i++)
            {
                int victoryPlayer1 = 0;
                int victoryPlayer2 = 0;

                string player1 = pairs[i][0];
                string player2 = pairs[i][1];



                while (victoryPlayer1 != rounds && victoryPlayer2 != rounds)
                {
                    winners[i] = Match(pairs[i]);

                    if (winners[i] == player1)
                    {
                        victoryPlayer1++;
                    }
                    else
                    {
                        victoryPlayer2++;
                    }



                }

                if (victoryPlayer1 == rounds)
                {
                    winners[i] = player1;
                }
                else
                {
                    winners[i] = player2;
                }



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
