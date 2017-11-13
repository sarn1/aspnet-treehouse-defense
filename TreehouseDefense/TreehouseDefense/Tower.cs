namespace TreehouseDefense
{
    class Tower
    {

        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; }  = 1;
        private readonly MapLocation _location;
        protected virtual double Accuracy { get; } = .75; //75% accuracy

        //initialized once and only once.
        //the members of a class can be declared using the storage class modifier static. These data members are shared by all instances of this class and are stored in one place.
        private static readonly System.Random _random = new System.Random();

        public Tower()
        {

        }

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return Tower._random.NextDouble() < Accuracy; //random num from 0-1
        }

        //towers are made to shoot
        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders) {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        System.Console.WriteLine("Shot and hit invader");

                        if (invader.IsNeutralized)
                        {
                            System.Console.Write("Invader nuetralized");
                        }
                    } else
                    {
                        System.Console.WriteLine("Shot and miss invader");
                    }
                    
                    break;
                }
            }
        }
    }
}
