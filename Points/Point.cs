namespace Points
{
    internal class Point
    {
        /// <summary>
        /// Static field shows number of created points. 
        /// </summary>
        public static int CountOfObjects { get; private set; }

        /// <summary>
        /// X coordinate of the point
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Y coordinate of the point
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Creates a point (0;0)
        /// </summary>
        public Point() 
        {
            CountOfObjects++;
        }

        /// <summary>
        /// Creates a point
        /// </summary>
        /// <param name="x">X coordinate of the point</param>
        /// <param name="y">Y coordinate of the point</param>
        public Point(double x, double y)
        {
            CountOfObjects++;
            X = x; 
            Y = y;
        }

        /// <summary>
        /// Calculates the distance between two points
        /// </summary>
        /// <param name="a">First point 'A'</param>
        /// <param name="b">Second point 'B'</param>
        /// <returns>Rounded integer value of distance between points</returns>
        public static int GetDistanceBetweenPoints(Point a, Point b) 
            => (int)Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));

        /// <summary>
        /// Calculates the distance to point from this point
        /// </summary>
        /// <param name="a">The point to which we calculate the distance</param>
        /// <returns>Rounded integer value of distance from this point to point 'A'</returns>
        public int GetDistanceToPoint(Point a)
            => (int)Math.Sqrt(Math.Pow((a.X - X), 2) + Math.Pow((a.Y - Y), 2));
    }
}
