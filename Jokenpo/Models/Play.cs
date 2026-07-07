using System;


namespace Jokenpo.Models
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
        

        public static int DetermineWinner (int move1, int move2)
        {
            Move player1 = (Move)move1;
            Move player2 = (Move)move2;


            if (player1 == Move.Paper && player2 == Move.Rock)
            {
                return (int)Move.Paper ;
            }
            if (player1 == Move.Rock && player2 == Move.Scissors)
            {
                return (int)Move.Rock ;
            }
            if (player1 == Move.Scissors && player2 == Move.Paper)
            {
                return (int)Move.Scissors ;
            }
            if (player1 == player2)
            {
                return 0;
            }
            else
            {
                return move2;    
            }
            
            
        }
        

        public static int RandomPlay ()
        {

            return numRandom.Next(1,4);
            
        }


        public static string MoveName(int move)
        {
            string moveWin = "";

            switch (move)
            {
                case 1:
                    moveWin = "Pedra";
                    break;
                case 2: 
                moveWin = "Papel";
                    break;
                case 3:
                    moveWin = "Tesoura";
                    break;
            }


            return moveWin;
        }
        
       
       
    }
}
