﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class ShieldedInvader : Invader
    {
        private static System.Random _random = new System.Random();

        public ShieldedInvader (Path path) : base(path)
        {
            
        }
        //overriding a base virtual method
        public override void DecreaseHealth(int factor) {
            //decrease at 50% of the time random
            if(_random.NextDouble() < .5)
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