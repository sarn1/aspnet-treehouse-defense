namespace TreehouseDefense
{
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
            //cartesian formula
            int xDiff = X - point.X;
            int yDiff = Y - point.Y;

            int xDiffSq = xDiff * xDiff;
            int yDiffSq = yDiff * yDiff;

            return (int)System.Math.Sqrt(xDiffSq + yDiffSq);
        }
    }
}
