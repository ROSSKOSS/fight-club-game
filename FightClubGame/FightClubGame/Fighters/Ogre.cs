using FightClubGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubGame.Fighters
{
    [CharacterTypeAttribute]
    class Ogre : IFighter
    {
        

        public Ogre()
        {
            
            bodyparts = new Dictionary<int, string>();
            Health = 150;
            bodyparts.Add(0, "left head");
            bodyparts.Add(1, "right head");
            bodyparts.Add(2, "left arm");
            bodyparts.Add(3, "right arm");
            bodyparts.Add(4, "torso");
            bodyparts.Add(5, "left leg");
            bodyparts.Add(6, "right leg");
        }

        public override string GetHit(IFighter attacker, int part, int damage)
        {
            string log = "Ogre " + Name;
            log += checkPoison();
            log += " block a " + bodyparts[blockedPart] + " and have attacked " + bodyparts[part];
            if (blockedPart != part)
            {
                
                    increaseHP(damage);
                    return log + " and have a dammage ";
                
            }
            return log + " and don't have dammage ";
        }
        
        public override string hitFighter(IFighter victime, int part)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int randomNumber = random.Next(0, 100);
            string res = "Ogre " + Name;
            int damage = 0;
            if (randomNumber >= 0 && randomNumber < 77)
            {
                damage = 20;
                res += " paid ordinary punch ";
            }
            else if (randomNumber >= 77 && randomNumber < 100)
            {
                damage = 30;
                res += " paid forced punch and terrified the victime, so will attac again ";
                if(hitBack!=null)
                return res + victime.GetHit(this, part, damage) + hitBack();
            }
            

            return res + victime.GetHit(this, part, damage);
        }
    }
}
