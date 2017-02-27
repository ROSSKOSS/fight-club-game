using FightClubGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubGame.Fighters
{
    [CharacterTypeAttribute]
    class Centaur : IFighter
    {
        public Centaur()
        {
            bodyparts = new Dictionary<int, string>();
            Health = 120;
            Name = "Centaur";
            bodyparts.Add(0, "head");
            bodyparts.Add(1, "left arm");
            bodyparts.Add(2, "right arm");
            bodyparts.Add(3, "front torso");
            bodyparts.Add(4, "back torso");
            bodyparts.Add(5, "left front leg");
            bodyparts.Add(6, "right front leg");
            bodyparts.Add(7, "left back leg");
            bodyparts.Add(8, "left back leg");
        }

        

        public override string GetHit(IFighter attacker, int part, int damage)
        {
            string log = "Centaur " + Name;
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
                    increaseHP(damage);
                    return log + " and have a dammage but he furious, and punch back " + hitBack();
                }
            }
            return log + " and don't have dammage ";
        }

        public override string hitFighter(IFighter victime, int part)
        {
            System.Threading.Thread.Sleep(1);
            Random random = new Random(DateTime.Now.Millisecond);
            int randomNumber = random.Next(0, 100);
            string res = "Centaur " + Name;
            int damage = 0;
            if (randomNumber >= 0 && randomNumber < 77)
            {
                damage = 20;
                res += " paid ordinary punch ";
            }
            else if (randomNumber >= 77 && randomNumber < 100)
            {
                damage = 5;
                res += " paid fast punch and paid second punch ";
                return res + victime.GetHit(this, part, damage) + hitFighter(victime, part);
            }


            return res + victime.GetHit(this, part, damage);
        }
    }
}
