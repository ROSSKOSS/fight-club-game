using FightClubGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// designed with Aurika
namespace FightClubGame.Fighters
{
    [CharacterTypeAttribute]
    class Vampire : IFighter
    {
        public Vampire()
        {
            bodyparts = new Dictionary<int, string>();
            Health = 100;
            Name = "Vampire";
            bodyparts.Add(0, "head");
            bodyparts.Add(1, "left arm");
            bodyparts.Add(2, "right arm");
            bodyparts.Add(3, "left wing");
            bodyparts.Add(4, "right wing");
            bodyparts.Add(5, "torso");
            bodyparts.Add(6, "left leg");
            bodyparts.Add(7, "right leg");
        }

        

        public override string GetHit(IFighter attacker, int part, int damage)
        {
            string log = "Vampire " + Name;
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
                    return log + " but he flew ";
                }
            }
            return log + " and don't have dammage ";
        }

        public override string hitFighter(IFighter victime, int part)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int randomNumber = random.Next(0, 100);
            string res = "Vampire " + Name;
            int damage = 0;
            if (randomNumber >= 0 && randomNumber < 50)
            {
                damage = 20;
                res += " paid ordinary punch ";
            }
            else if (randomNumber >= 50 && randomNumber < 75)
            {
                damage = 30;
                res += " paid strong punch, pounce on a victim and take a health power ";
                Health += 35;
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

