using System;

namespace Jokenpo
{
    public class Tourneament
    {
        public static void Start()
        {
            string[][] pairs = PairsDraw.PairsStart();

            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair[0]} x {pair[1]}");
            }


            
        }

       
        
    }

    
}
