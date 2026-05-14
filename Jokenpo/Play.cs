using System;


namespace Jokenpo
{
    public class Play
    {

        private static Random numRandom = new Random();

        enum Move
        {
            Rock = 1,
            Paper = 2,
            Scissors = 3
        }
        

        public static string DetermineWinner (int move1, int move2)
        {
            Move player1 = (Move)move1;
            Move player2 = (Move)move2;


            if (player1 == Move.Paper && player2 == Move.Rock)
            {
                return $"Player1 wins" ;
            }
            if (player1 == Move.Rock && player2 == Move.Scissors)
            {
                return $"Player1 wins" ;
            }
            if (player1 == Move.Scissors && player2 == Move.Paper)
            {
                return $"Player1 wins" ;
            }
            if (player1 == player2)
            {
                return "Draw, play again";
            }
            return $"Player2 wins";
            
        }
        

        public static int RandomPlay ()
        {

            return numRandom.Next(1,4);
            
        }       
        
       
    }
}
