using System;


namespace Jokenpo
{
    public class Play
    {

        enum Result
        {
            Move1 = 1,
            Move2 = 2,
            BreakEven = 3
        }

        enum Move
        {
            Rock = 1,
            Paper = 2,
            Scissors = 3
        }
        

        private static Result CheckMove (Move move1, Move move2)
        {

            if (move1 == Move.Paper && move2 == Move.Rock)
            {
                return Result.Move1 ;
            }
            if (move1 == Move.Rock && move2 == Move.Scissors)
            {
                return Result.Move1 ;
            }
            if (move1 == Move.Scissors && move2 == Move.Paper)
            {
                return Result.Move1 ;
            }
            if (move1 == move2)
            {
                return Result.BreakEven;
            }
            return Result.Move2;
            
        }

        public static void PrintWinnerMove()
        {
            Console.WriteLine(CheckMove(Move.Paper, Move.Scissors));
        }
    }
}
