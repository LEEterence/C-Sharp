/*
 * Exercise:
Write a program that can find the distance between two points, given the points’ x and y coordinates.

Requirements:
Create a Point structure that holds the x and y coordinates of a point on a graph. 
Use properties to hold the data, and 
use the automatic properties syntax to define them.

Write a method that accepts two Point structures as parameters and returns the distance between them. 
The distance formula, given two points with coordinates at (x1, y1) and (x2, y2), respectively, is  distance =(x2 - x1)^2 + (y2 - y1)^2 
 * 
 */

using System;

namespace Course_Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            double distance;

            Console.Write("Enter the x coordinate for point 1: ");
            point1.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y coordinate for point 1: ");
            point1.y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the x coordinate for point 2: ");
            point2.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y coordinate for point 2: ");
            point2.y = Convert.ToInt32(Console.ReadLine());

            distance = PointDistance(point1, point2);

            Console.WriteLine($"The distance between these two points is {distance:N2}");
        }

        static double PointDistance(Point point1, Point point2)
        {
            double totalDistance;
            totalDistance = Math.Sqrt(Math.Pow((point1.x - point2.x), 2) + Math.Pow((point1.y - point2.y), 2));
            return totalDistance;
        }
    }
}
