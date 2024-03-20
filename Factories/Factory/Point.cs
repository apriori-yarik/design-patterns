using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Point
    {
        public double x, y;

        // Valid if we use PointFactory
        //public Point(double x, double y)
        //{
        //    this.x = x;
        //    this.y = y;
        //}

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static class Factory
        {
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double r, double theta)
            {
                return new Point(r * Math.Cos(theta), r * Math.Sin(theta));
            }
        }
    }
}
