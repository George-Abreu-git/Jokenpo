using System;

namespace Jokenpo.Models
{
    public class GetRounds
    {
        //Ler quantidade de rounds do usuário
        public static int SetRounds()
        {
            Console.WriteLine("Defina a quantidade de rodadas: ");
            int rounds = Convert.ToInt32(Console.ReadLine());

            return rounds;
        }
    }
}