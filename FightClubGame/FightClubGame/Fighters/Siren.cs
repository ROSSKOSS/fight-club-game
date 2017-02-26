using FightClubGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubGame.Fighters
{
    [CharacterTypeAttribute]
    class Siren : IFighter
    {
         public Siren()
        {
            bodyparts = new Dictionary<int, string>();
            Health = 100;
            bodyparts.Add(0, "head");
            bodyparts.Add(1, "left wing");
            bodyparts.Add(2, "right wing");
            bodyparts.Add(3, "torso");
            bodyparts.Add(4, "tail");
        }

        

        public override string GetHit(IFighter attacker, int part, int damage)
        {
            string log = "Siren " + Name;
            //log += checkPoison(); сирена ядовита сама и не отравляеться

            log += " block a " + bodyparts[blockedPart] + " and have attacked " + bodyparts[part];
            if (blockedPart != part)
            {
                Random random = new Random(DateTime.Now.Millisecond);
                int randomNumber = random.Next(0, 100);
                if (randomNumber >= 0 && randomNumber < 80)
                {
                    increaseHP(damage);
                    return log + " and have a dammage ";
                }
                else if (randomNumber >= 80 && randomNumber < 90)
                {
                    return log + " but she flew ";
                }else if (randomNumber >= 90 && randomNumber < 100)
                {
                    increaseHP(damage);
                    return log + " and have a dammage, but her blood fell on the enemy and poisoned him "+attacker.poisoning(2);
                }
            }
            return log + " and don't have dammage ";
        }

        public override string hitFighter(IFighter victime, int part)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int randomNumber = random.Next(0, 100);
            string res = "Siren " + Name;
            int damage = 0;
            if (randomNumber >= 0 && randomNumber < 80)
            {
                damage = 20;
                res += " paid ordinary punch ";
            }
            else if (randomNumber >= 80 && randomNumber < 100)
            {
                damage = 10;
                res += " paid a week punch but she splat venom " + victime.poisoning(2);
            }
            

            return res + victime.GetHit(this, part, damage);
        }
    }



}

