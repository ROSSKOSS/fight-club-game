using FightClubGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubGame.Fighters
{
    [CharacterTypeAttribute]
    class Human : IFighter
    {

        public Human()
        {
            bodyparts = new Dictionary<int, string>();
            Health = 100;
            Name = "Human";
            bodyparts.Add(0, "head");
            bodyparts.Add(1, "left arm");
            bodyparts.Add(2, "right arm");
            bodyparts.Add(3, "torso");
            bodyparts.Add(4, "left leg");
            bodyparts.Add(5, "right leg");
        }

        

        public override string GetHit(IFighter attacker, int part, int damage)
        {
            string log = "Human " + Name;
            log += checkPoison();
            log +=" block a " + bodyparts[blockedPart] + " and have attacked " + bodyparts[part];
            if (blockedPart != part)
            {
                Random random = new Random(DateTime.Now.Millisecond);
                int randomNumber = random.Next(0, 100);
                if (randomNumber >= 0 && randomNumber < 60)
                {
                    increaseHP(damage);
                    return log + " and have a dammage ";
                }
                else if (randomNumber >= 60 && randomNumber < 100)
                {
                    return log + " but he dodged ";
                }
            }
            return log + " and don't have dammage ";
        }

        public override string hitFighter(IFighter victime, int part)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int randomNumber = random.Next(0, 100);
            string res = "Human " + Name;
            int damage = 0;
            if (randomNumber >= 0 && randomNumber < 50)
            {
                damage = 20;
                res += " paid ordinary punch ";
            }
            else if (randomNumber >= 50 && randomNumber < 75)
            {
                damage = 30;
                res += " paid strong punch ";
            }
            else if (randomNumber >= 75 && randomNumber < 100)
            {
                damage = 15;
                res += " paid week punch ";
            }

            return res + victime.GetHit(this, part, damage);
        }
    }

}

