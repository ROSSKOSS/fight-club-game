using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubGame.Core
{
    class Player
    {
        public string Name { get; set; }
        public IFighter Character { get; set; }
        public IActor opponent;
        public int decideHitPart(int part)
        {
            return part;
        }
        public string hitActor(int part)
        {
            if (Character.Health <= 0) return Character.Name + " is death ";
            if (opponent.Character.Health <= 0) return opponent.Character.Name + " is death ";
            return Character.hitFighter(opponent.Character, decideHitPart(part));
        }
    }
}
