using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace wonderful_tools
{
    public class Point
    {
        Nullable<double> x, y;

        public Point()
        {
            x = null;
            y = null;
        }

        public Point(Nullable<double> x, Nullable<double> y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetX(double x) => this.x = x;

        public Nullable<double> GetX() => x;

        public void SetY(double y) => this.y = y;

        public Nullable<double> GetY() => y;

        public void WhatIsQuater(out char quater)
        {
            if (x > 0 && y > 0)
                quater = (char)1;
            else if (x < 0 && y > 0)
                quater = (char)2;
            else if (x < 0 && y < 0)
                quater = (char)3;
            else
                quater = (char)4;
        }

        public static bool IsOneQuater(Point p1, Point p2)
        {
            p1.WhatIsQuater(out char quater_of_1);
            p2.WhatIsQuater(out char quater_of_2);

            return quater_of_1 == quater_of_2;
        }

        public static void DistanceBetweenTwoPoints(Point p1, Point p2, out double d)
            => d = Math.Sqrt(Math.Pow((double)(p2.GetX() - p1.GetX()), 2) + Math.Pow((double)(p2.GetY() - p1.GetY()), 2));

        public static void SetDefaultIfNull(
            Point p1, 
            Point p2, 
            Point p3)
        {
            if (p1.GetX() is null)
                p1.SetX(0.0);
            if (p1.GetY() is null)
                p1.SetY(0.0);

            if (p2.GetX() is null)
                p2.SetX(2.0);
            if (p2.GetY() is null)
                p2.SetY(0.0);

            if (p3.GetX() is null)
                p3.SetX(1.0);
            if (p3.GetY() is null)
                p3.SetY(2.0);
        }

        public static void SquareOfTriangle(
            Point p1, 
            Point p2, 
            Point p3, 
            out double S)
        {
            SetDefaultIfNull(p1, p2, p3);

            Point mp = new Point(
                ((p1.GetX() + p2.GetX()) / 2.0), p1.GetY()
            );

            DistanceBetweenTwoPoints(mp, p3, out double h);
            DistanceBetweenTwoPoints(p1, p2, out double a);

            S = (a * h) / 2.0;
        }

        public static void PerimetrOfTriangle(
            Point p1,
            Point p2,
            Point p3,
            out double P)
        {
            SetDefaultIfNull(p1, p2, p3);

            DistanceBetweenTwoPoints(p1, p2, out double fs);
            DistanceBetweenTwoPoints(p2, p3, out double ss);
            DistanceBetweenTwoPoints(p3, p1, out double ts);

            P = fs + ss + ts;
        }
    }

    public static class WonderfulTools
    {
        public static int FindCountRow(double[,] nums)
        {
            var count = 0;

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                var sum = 0.0;

                for (int j = 0; j < nums.GetLength(1); j++)
                    sum += nums[i, j];

                count = sum / nums.GetLength(1) < 0 ? ++count : count;
            }

            return count;
        }

        public static double CalcFuncA(double x, double y)
            => (Math.Sqrt(Math.Abs(x - 1)) - Math.Sqrt(Math.Abs(y)))
                / (1 + (Math.Pow(x, 2) / 2) + (Math.Pow(y, 2) / 4));

        public static double CalcFuncB(double x, double z)
            => x * (Math.Atan(z) + Math.E);

        public static double SumElems(double[] A)
            => A.Sum();

        public static void CalcU(in double a, in double b, out double u)
            => u = Math.Max(a, b - a);

        public static void CalcV(in double a, in double b, out double v)
            => v = Math.Min(a * b, a + b);

        public static void CalcK(in double u, in double v, ref double k)
            => k = Math.Min(u + v * 2, Math.PI);
    }
}
