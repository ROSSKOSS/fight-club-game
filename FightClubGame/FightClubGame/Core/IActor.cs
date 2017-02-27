using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubGame.Core
{
    abstract class IActor
    {
        public string Name { get; set; }
        public IFighter Character { get; set; }
        public IActor opponent;

        abstract public int decideHitPart();
        abstract public void decideBlockPart();
        public string hitActor()
        {
            if (Character.Health <= 0) return Character.Name + " is dead ";
            if (opponent.Character.Health <= 0) return opponent.Character.Name + " is dead ";
            return Character.hitFighter(opponent.Character, decideHitPart());
        }

#region initialisation
        public void setEvent()
        {
            Character.hitBack += hitActor;
        }
        public void setOpponent(IActor opp)
        {
            opponent = opp;
        }
#endregion

    }
}
