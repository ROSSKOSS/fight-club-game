using FightClubGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubGame.Fighters
{
    [CharacterTypeAttribute]
    class Orc : IFighter
    {
        public Orc()
        {
            bodyparts = new Dictionary<int, string>();
            Health = 120;
            Name = "Orc";
            bodyparts.Add(0, "head");
            bodyparts.Add(1, "left arm");
            bodyparts.Add(2, "right arm");
            bodyparts.Add(3, "torso");
            bodyparts.Add(4, "left leg");
            bodyparts.Add(5, "right leg");
        }

        

        public override string GetHit(IFighter attacker, int part, int damage)
        {
            string log = "Orc " + Name;
            log += checkPoison();
            log += " block a " + bodyparts[blockedPart] + " and have attacked " + bodyparts[part];
            if (blockedPart != part)
            {
                Random random = new Random(DateTime.Now.Millisecond);
                int randomNumber = random.Next(0, 100);
                if (randomNumber >= 0 && randomNumber < 90)
                {
                    increaseHP(damage);
                    return log + " and have a dammage ";
                }
                else if (randomNumber >= 90 && randomNumber < 100)
                {
                    return log + " but he reflected some damage "+attacker.GetHit(this,part,10);//отражаем в то, что атаковало
                }
            }
            return log + " and don't have dammage ";
        }
        
        public override string hitFighter(IFighter victime, int part)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int randomNumber = random.Next(0, 100);
            string res = "Orc " + Name;
            int damage = 0;
            if (randomNumber >= 0 && randomNumber < 77)
            {
                damage = 20;
                res += " paid ordinary punch ";
            }
            else if (randomNumber >= 77 && randomNumber < 100)
            {
                damage = 40;
                res += " paid critical punch ";
            }


            return res + victime.GetHit(this, part, damage);
        }
    }
}
