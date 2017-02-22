using System;
using System.Collections.Generic;
using System.Linq;

//Create class Circle with properties Center and Radius.The center is a point with coordinates X and Y(make a class Point). 
//Write a method bool Intersect(Circle c1, Circle c2) that tells whether the two given circles intersect or not.
//Write a program that tells if two circles intersect.
//The input lines will be in format: { X} {Y} {Radius}. Print as output “Yes” or “No”.


class IntersectionOfCircles
{
    static void Main()
    {
        int[] firstToken = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] secondToken = Console.ReadLine().Split().Select(int.Parse).ToArray();

        //Point centerA = new Point { X = firstToken[0], Y = firstToken[1] };
        //Point cetnerB = new Point { X = secondToken[0], Y = secondToken[1] };

        Circle circleA = new Circle()
        {
            Center = new Point { X = firstToken[0], Y = firstToken[1] },
            Radius = firstToken[2]
        };

        Circle circleB = new Circle
        {
            Center = new Point { X = secondToken[0], Y = secondToken[1] },
            Radius = secondToken[2]
        };

        if (Circle.Intersect(circleA, circleB))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}

class Circle
{
    public Point Center = new Point();
    public int Radius { get; set; }

    public static bool Intersect(Circle one, Circle two)
    {
        double distanceBetweenCenters = DistanceBetweenPoints(one.Center, two.Center);
        double sumOfRadiuses = one.Radius + two.Radius;

        if (distanceBetweenCenters <= sumOfRadiuses)
        {
            return true;
        }

        return false;
    }

    static double DistanceBetweenPoints(Point one, Point two)
    {
        int x1 = one.X;
        int y1 = one.Y;

        int x2 = two.X;
        int y2 = two.Y;

        int sideX = Math.Abs(x1 - x2);
        int sideY = Math.Abs(y1 - y2);

        double distanceBetweenCenters = Math.Sqrt(sideX * sideX + sideY * sideY);

        return distanceBetweenCenters;
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

