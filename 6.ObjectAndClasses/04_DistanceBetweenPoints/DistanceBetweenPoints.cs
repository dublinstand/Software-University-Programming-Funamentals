using System;
using System.Linq;

class DistanceBetweenPoints
{
    static void Main()
    {
        Point p1 = ReadPoint();
        Point p2 = ReadPoint();

        Console.WriteLine("{0:f3}", CalcDistance(p1, p2));
    }



    static Point ReadPoint()
    {
        int[] tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Point point = new Point();
        point.X = tokens[0];
        point.Y = tokens[1];

        return point;

    }

    static double CalcDistance(Point p1, Point p2)
    {
        int sideA = Math.Abs(p1.X - p2.X);
        int sideB = Math.Abs(p1.Y - p2.Y);
        double shortestDistance = Math.Sqrt(sideA * sideA + sideB * sideB);

        return shortestDistance;
    }
}

class Point {
    public int X { get; set; }
    public int Y { get; set; }
}


