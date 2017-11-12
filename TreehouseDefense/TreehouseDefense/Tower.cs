namespace TreehouseDefense
{
    class Tower
    {

        private const int _range = 1;
        private const int _power = 1;
        private readonly MapLocation _location;
        private const double _accuracy = .75;

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
            return Tower._random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders) {
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
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
