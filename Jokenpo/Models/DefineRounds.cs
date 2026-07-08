using System;

namespace Jokenpo.Models
{
    public class GetRounds
    {
        //Ler quantidade de rounds do usuário
        public static int SetRounds()
        {
            int rounds;

            while (true)
            {
                Console.WriteLine($"Defina a quantidade de rounds: ");
                string? rawInput = Console.ReadLine();

                if (rawInput != null && int.TryParse(rawInput, out rounds) && IsValidQuantity(rounds))
                {
                    return rounds;
                }
                Console.Clear();
                Console.WriteLine($"Mínimo 1 round");
            }
        }

        private static bool IsValidQuantity(int amount)
        {
            return amount > 0;


        }


    }
}
