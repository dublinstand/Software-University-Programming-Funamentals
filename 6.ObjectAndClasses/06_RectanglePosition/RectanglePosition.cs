using System;
using System.Linq;

//Write a program to read two rectangles {left, top, width, height} and print whether the first is inside the second.
//The input is given as two lines, each holding a rectangle, described by 4 integers: left, top, width and height.


class RectanglePosition
{
    static void Main()
    {
        Rectangle rectangle1 = new Rectangle();
        Rectangle rectangle2 = new Rectangle();

        rectangle1 = Rectangle.readRectangle();
        rectangle2 = Rectangle.readRectangle();

        Boolean isInside = rectangle1.IsInside(rectangle2);

        if (isInside)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not Inside");
        }
    }
}

class Rectangle
{
    public int Top { get; set; }
    public int Left { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    int CalcArea()
    {
        return Width * Height;
    }

    public int Bottom
    {
        get
        {
            return Top + Height;
        }
    }

    public int Right
    {
        get
        {
            return Left + Width;
        }
    }

    public bool IsInside(Rectangle r)
    {
        return (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) && (r.Bottom >= Bottom);
    }

    public static int calcarea(string width, string height)
    {
        return int.Parse(width) * int.Parse(height);
    }

    public static Rectangle readRectangle ()
    {
        int[] token = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Rectangle rectangle = new Rectangle();
        rectangle.Left = token[0];
        rectangle.Top = token[1];
        rectangle.Width = token[2];
        rectangle.Height = token[3];

        return rectangle;
    }

}