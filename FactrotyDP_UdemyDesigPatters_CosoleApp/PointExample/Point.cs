using FactrotyDP_UdemyDesigPatters_CosoleApp.PointExample.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactrotyDP_UdemyDesigPatters_CosoleApp.PointExample
{
    public class Point
    {
        private double x, y;
        
        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        // factory method design patern
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }
        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }
        public override string ToString()
        {
            return $"{nameof(x)} = {x}\n{nameof(y)} = {y}";
        }
    }
}
