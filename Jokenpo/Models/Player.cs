using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Jokenpo.Models
{
    public abstract class Player
    {
        private string _name;
    
        public string Name
        {
            get => _name;

            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nome deve ser definido.");
                }
                _name = value;
            }
        }

        public int Points {get; private set;}

        public int? Rank {get; private set; }

        public Player(string name)
        {
            Name = name;
        }
        public void UpdateRank(int newRank)
        {
            Rank = newRank;
            
        }

        


         public void AddPoints()
        {
            Points ++;
        }

        public abstract int PlayerMove();

    }
}