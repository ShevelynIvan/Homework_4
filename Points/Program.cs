namespace Points
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point() { X = 0.95, Y = 16.4 };
            Point p2 = new Point() { X = -5.5, Y = 1.31 };
            Point p3 = new Point(1, 1);
            Console.WriteLine($"Count of created points = {Point.CountOfObjects}");
            Console.WriteLine($"Distance from p1 to p2 = {Point.GetDistanceBetweenPoints(p1, p2)}");
            Console.WriteLine($"Distance from p2 to p1 = {p2.GetDistanceToPoint(p1)}");
            Console.WriteLine($"Distance from p2 to p3 = {p2.GetDistanceToPoint(p3)}");
            Console.WriteLine($"Distance from p1 to p3 = {Point.GetDistanceBetweenPoints(p1, p3)}");
        }
    }
}