namespace TreehouseDefense
{
    //represents a coordinate on the map thus initialize with x and y
    //gen purpose to represent a point in a grid
    //maplocation is a sub class of this
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            //cartesian formula
            int xDiff = X - x;
            int yDiff = Y - y;

            int xDiffSq = xDiff* xDiff;
            int yDiffSq = yDiff* yDiff;

            return (int) System.Math.Sqrt(xDiffSq+ yDiffSq);
        }

        //overloading
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
