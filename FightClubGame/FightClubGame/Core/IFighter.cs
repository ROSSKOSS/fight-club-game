using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubGame.Core
{
    //abstract class IFighter<T> where T : struct
    abstract class IFighter
    {
        public delegate string hitActorHendler();
        public hitActorHendler hitBack;
        public Dictionary<int, string> bodyparts { get; set; }

        public int blockedPart { get; set; }
        public string Name { get; set; }//а должны ли мы подписывать персонажа или героя?
        public int Health { get; set; }
        public int isPoisoned = 0;

        abstract public string GetHit(IFighter attacker, int part, int damage);
        abstract public string hitFighter(IFighter victime, int part);

        public void increaseHP(int value)
        {
            Health -= value;
        }
        public string poisoning(int time)
        {
            isPoisoned += time;
            return Name + " is poisoned for " + time + " rounds ("+isPoisoned+"at all) ";
        }
        public void SetBlock(int part)
        {
            blockedPart = part;
        }
        public string checkPoison()
        {
            if (isPoisoned > 0)
            {
                --isPoisoned;
                increaseHP(15);
                return " have a damage from poison ";
            }
            return null;
        }


    }

}
