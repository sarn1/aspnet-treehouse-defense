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

        public override string ToString()
        {
            return X + "," + Y;
        }

        //if coordinanace of 2 points are the same.  this 
        //is auto-inherit by maplocation
        public override bool Equals(object obj)
        {
            //make sure its type point and also not null
            if(!(obj is Point))
            {
                return false;
            }

            //cast obj into a point
            Point that = obj as Point;

            return this.X == that.X && this.Y == that.Y;
        }

        public override int GetHashCode()
        {
            //by multiplying by a prime, it'll be unique
            return X.GetHashCode() * 31 + Y.GetHashCode(); 
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
