using System;
using System.Linq;

//Write a program to read n points and find the closest two of them.
//Input
//The input holds the number of points n and n lines, each holding a point {X and Y coordinate}.
//Output
//•	The output holds the shortest distance and the closest two points.
//•	If several pairs of points are equally close, print the first of them(from top to bottom). 


class ClosestTwoPoints
{
    static void Main()
    {
        Point[] points = Point.ReadPoints();
        Point[] closestPoint = Point.FindClosestPoint(points);
        //Point p1 = new Point() { X = 3, Y = 4 };
        //Point p2 = new Point() { X = 2, Y = 5 };
        //Console.WriteLine(Point.CalcDistance(p1, p2));

        Console.WriteLine("{0:f3}", Point.CalcDistance(closestPoint[0], closestPoint[1]));
        Point.PrintPoint(closestPoint[0]);
        Point.PrintPoint(closestPoint[1]);

    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Point ReadPoint()
    {
        int[] tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Point point = new Point();
        point.X = tokens[0];
        point.Y = tokens[1];

        return point;
    }

    public static double CalcDistance(Point p1, Point p2)
    {
        int sideA = p2.X - p1.X;
        int sideB = p2.Y - p1.Y;
        double shortestDistance = Math.Sqrt(sideA * sideA + sideB * sideB);

        return shortestDistance;
    }

    public static Point[] ReadPoints()
    {
        int n = int.Parse(Console.ReadLine());
        Point[] points = new Point[n];

        for (int i = 0; i < n; i++)
        {
            points[i] = Point.ReadPoint();
        }

        return points;
    }

    public static Point[] FindClosestPoint(Point[] points)
    {
        Point[] closestPoints = null;
        double closestDistance = double.MaxValue;

        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                double closestDistanceNew = CalcDistance(points[i], points[j]);

                if ( closestDistanceNew < closestDistance)
                {
                    closestDistance = closestDistanceNew;
                    closestPoints = new Point[] { points[i], points[j] };
                }
            }
        }
        return closestPoints;
    }

    public static void PrintPoint(Point point)
    {
        Console.WriteLine("({0}, {1})", point.X, point.Y);
    }
}