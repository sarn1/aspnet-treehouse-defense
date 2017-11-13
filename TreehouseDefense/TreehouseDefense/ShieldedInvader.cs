using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class ShieldedInvader : Invader
    {
        //now uses from random.cs class
        //private static System.Random _random = new System.Random();

        public override int Health { get; protected set; } = 2;

        public ShieldedInvader (Path path) : base(path)
        {
            
        }
        //overriding a base virtual method
        public override void DecreaseHealth(int factor) {
            //decrease at 50% of the time random
            if(Random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor); //call base's DecreaseHealth
            }
            else
            {
                System.Console.WriteLine("Shot at, but sustained the damage.");
            }
        }
    }
}
