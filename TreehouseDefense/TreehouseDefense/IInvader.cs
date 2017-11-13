namespace TreehouseDefense
{
    interface IMappable
    {
        MapLocation Location { get; }
    }

    interface IMoveable
    {
        void Move();
    }

    //inherits from IMoveable and IMappable
    interface IInvader : IMappable , IMoveable
    {
        //from Invader.cs abstraction class
        //only defines public
        MapLocation Location { get;  }

        int Health { get; } 

        bool HasScored { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void DecreaseHealth(int factor);
    }
}
