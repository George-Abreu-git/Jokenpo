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
            

            Console.WriteLine($"Campeão é {players[0]}");
            
        }


        //Executa rodadas a partir partida
        private static string[] JogarRodadas(string [][]pairs)
        {
          //atribui o tamanho de pairs em vencedores
          string [] vencedores = new string[pairs.Length];

          for (int i = 0; i < pairs.Length; i++)
            {
                vencedores[i] = Partida(pairs[i]);
            }

          return vencedores;  
        }

        //Executa apenas 1 partida entre 2 jogadores
        private static string Partida(string [] pair)
        {
            //jogador1 e jogador 2 recebem 0 e 1 da lista de par
            string jogador1 = pair[0];
            string jogador2 = pair[1];

            int jogada1 = 0;
            int jogada2 = 0;
            int resultado = 0;

            //enquanto resultado for empate repete jogadas
            while(resultado == 0)
            {
                jogada1 = Play.RandomPlay();
                jogada2 = Play.RandomPlay();

                resultado = Play.DetermineWinner(jogada1,jogada2);
            }

            if(resultado == jogada1)
            {
                return jogador1;   
            }else
            {
                return jogador2;
            }
            
        }

    }

    
}
