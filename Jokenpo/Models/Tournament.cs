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
                string byeFixed = FixBye(players, out string[] playersWithoutBye);
                string[][] pairs = PairsDraw.CreatePairs(playersWithoutBye);
                string[] winners = RunRound(pairs, rounds);
                
                if(byeFixed != "")
                {
                    string[] winnersFull = new string[winners.Length+1];
                    Array.Copy(winners, winnersFull, winners.Length);
                    winnersFull[winnersFull.Length - 1] = byeFixed;
                    players = winnersFull;

                } else
                {
                    
                    players = winners;    
                }

                


            }


            Console.WriteLine($"O campeão é {players[0]}");

        }


        //Executa rodadas a partir de Match
        private static string[] RunRound(string[][] pairs, int rounds)
        {
            //atribui o tamanho de pairs em winners
            string[] winners = new string[pairs.Length];
            string[] losersList = new string[pairs.Length];
            string[] winnersList = new string[pairs.Length];
            



            for (int i = 0; i < pairs.Length; i++)
            {
                int victoryPlayer1 = 0;
                int victoryPlayer2 = 0;

                string player1 = pairs[i][0];
                string player2 = pairs[i][1];
                
 




                while (victoryPlayer1 != rounds && victoryPlayer2 != rounds)
                {
                    winners[i] = Match(pairs[i]);

                    Console.WriteLine($"{player1} x {player2}");
                    




                    if (winners[i] == player1)
                    {
                        victoryPlayer1++;
                        Thread.Sleep(2000);
                        Console.WriteLine($"{player1} ganhou {victoryPlayer1} rodadas!");
                        

                    }
                    else
                    {
                        victoryPlayer2++;
                        Thread.Sleep(2000);
                        Console.WriteLine($"{player2} ganhou {victoryPlayer2} rodadas!");
    
                    }



                }

                if (victoryPlayer1 == rounds)
                {
                    winners[i] = player1;
                    Thread.Sleep(2000);
                    Console.WriteLine($"{player1} ganhou!");
                    winnersList[i] = player1;
                    losersList[i] = player2;

                }
                else
                {
                    winners[i] = player2;
                    Thread.Sleep(2000);
                    Console.WriteLine($"{player2} ganhou!");
                    winnersList[i] = player2;
                    losersList[i] = player1;
                }

                

            }

            foreach(string winner in winnersList)
            {
               
                Console.WriteLine($"Vencedores: {winner}");
                
            }

            foreach(string loser in losersList)
            {
               
                Console.WriteLine($"Perdedores: {loser}");
                
            }

             //Console.WriteLine($"Perdedores: {losersList[i]} e Vencedores: {winnersList[i]}");
           
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

        public static string FixBye(string[] players, out string[] playersWithoutBye)
        {
            string bye = "";
            string[]playersOutBye = new string[players.Length];

            if(players.Length %2 != 0)
            {

                bye = players[players.Length -1];
                Array.Copy(players, playersOutBye, players.Length -1);
                playersWithoutBye = playersOutBye;
                Console.WriteLine($"{bye}");   
                
            } else
            {
                Array.Copy(players, playersOutBye,players.Length);
                playersWithoutBye = playersOutBye;
                Console.WriteLine($"{bye}"); 
            }
            
            
            return bye;
                      
        }

    }


}
