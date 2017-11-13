namespace TreehouseDefense
{
    class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            //prevent out of range pathstep
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }

        //towers can't be on the path, so there needs to be a way to provide a 
        //map location as a parameter and see if its in the path or not
        public bool IsOnPath(MapLocation location)
        {
            foreach (var pathLocation in _path)
            {
                //see Equal override in point.cs for this feature
                if (location.Equals(pathLocation))
                {
                    // diff from == where == means if its the same "obj"
                    // equal means same coordinance
                    // string, int, double == is the same as equal, meaning 
                    // exact same value
                    return true;
                }
            }

            return false;
        }
    }
}