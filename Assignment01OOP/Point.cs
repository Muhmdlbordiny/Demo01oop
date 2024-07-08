using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOP
{
    public struct Point
    {
        public double X1;
        public double Y1;
        public double X2;
        public double Y2;
        public Point(double _x,double _y)
        {
            X1= _x;
            Y1= _y;
        }
        public Point(double _x1 ,double _y1,double _x2,double _y2)
        {
            X1 = _x1;
            Y1= _y1;
            X2 = _x2;
            Y2 = _y2;
                
        }
        public override string ToString()
        {
            return $"{this.X1} ,{this.Y1}";

        }
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

    }
}
