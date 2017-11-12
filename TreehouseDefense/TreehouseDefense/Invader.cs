namespace TreehouseDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        public MapLocation Location {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }

        /*
         * The above can also be written as :
         * public MapLocation Location => _path.GetLocationAt(_pathStep);
         */

        public int Health { get; private set; } = 2; //set Health at 2 during constructor

        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move()
        {
            _pathStep += 1;
        }

        /*
         * The above can be written as :
         * public void Move => _pathStep += 1;
         */

        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
    }
}