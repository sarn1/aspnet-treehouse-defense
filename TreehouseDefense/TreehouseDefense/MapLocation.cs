namespace TreehouseDefense
{
    class MapLocation : Point
    {
        public MapLocation (int x, int y, Map map) : base (x, y)
        {
            //throw exception if not on map
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException("Out of bounds!");
            }
        }
    }
}
