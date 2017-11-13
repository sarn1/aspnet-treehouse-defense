namespace TreehouseDefense
{
    interface IInvader
    {
        //from Invader.cs abstraction class
        //only defines public
        MapLocation Location { get;  }

        int Health { get; } 

        bool HasScored { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void Move();

        void DecreaseHealth(int factor);
    }
}
