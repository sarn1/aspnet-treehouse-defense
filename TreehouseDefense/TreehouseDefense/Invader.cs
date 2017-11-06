namespace TreehouseDefense
{
    class Invader
    {
        private MapLocation _location;

        // use properties instead of traditional getter/setter methods
        public MapLocation Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
    }
}