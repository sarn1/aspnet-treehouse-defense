namespace TreehouseDefense
{
    abstract class Invader : IInvader //uses IInvader interface
    {
        private readonly Path _path;
        private int _pathStep = 0; //invaders keep their own path

        protected virtual int StepSize { get; } = 1 ;  //fastinvader overrides this with 2

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

        //need to set to protected so that subclass can set.
        //forces all subclass to provide implementation of health
        public abstract int Health { get; protected set; } //set Health at 2 during constructor

        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        //invaders can move...
        public void Move()
        {
            _pathStep += StepSize;
        }

        /*
         * The above can be written as :
         * public void Move => _pathStep += 1;
         */

        //and invaders can lose health
        //virtual allows it to be override in a subclass
        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
    }
}