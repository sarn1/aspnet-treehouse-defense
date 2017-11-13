namespace TreehouseDefense
{
    //a subclass of point, more specific to the treehouse game
    class MapLocation : Point
    {

        //takes x and y and passes up to the base
        public MapLocation (int x, int y, Map map) : base (x, y)
        {
            //throw exception if not on map
            if (!map.OnMap(this))
            {
                //exception we made ourselves see exceptions.cs
                throw new OutOfBoundsException("Out of bounds!");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
