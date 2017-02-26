using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubGame.Core
{

    class Computer : IActor
    {
        public Computer()
        {
            //character = pers;
        }

        public override void decideBlockPart()
        {
            System.Threading.Thread.Sleep(1);
            Random random = new Random(DateTime.Now.Millisecond);
            int randomNumber = random.Next(0, Character.bodyparts.Count);
            Character.SetBlock(randomNumber);
        }

        public override int decideHitPart()
        {
            System.Threading.Thread.Sleep(1);
            Random random = new Random(DateTime.Now.Millisecond);
            return random.Next(0, opponent.Character.bodyparts.Count);
        }


        
    }
}
