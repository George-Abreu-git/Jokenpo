using System;


namespace Jokenpo.Models
{
    public class GetPlayers
    {

        public static string[] GetNameOfPlayers()
        {
            int quantity = InputQuantityOfPlayers();
            string[] nameOfPlayers = new string[quantity];

            for (int i = 0; i < nameOfPlayers.Length; i++)
            {

                nameOfPlayers[i] = $"Player {i + 1}";


            }

            return nameOfPlayers;

        }


        private static int InputQuantityOfPlayers()
        {
            int input;

            while (true)
            {
                Console.Write($"Digite a quantidade de jogadores (número par) : ");
                string? rawInput = Console.ReadLine();

                if (rawInput != null && int.TryParse(rawInput, out input) && IsValidQuantity(input))
                {
                    return input;
                }
                Console.Clear();
                Console.WriteLine($"Apenas número par.");

            }
        }

        private static bool IsValidQuantity(int amount)
        {
            return amount > 0 && amount % 2 == 0;
        }



        
    }
}
