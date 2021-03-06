using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildCircleLab
{
    class Circle
    {
        private double radius = 0;
        private double circumference => 2 * Math.PI * radius;
        private double area => Math.PI * radius * radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double Circumference { get { return circumference; } }
        public double Area { get { return area; } }

        public Circle(double incomingRadius)
        {
            Radius = incomingRadius;
        }


        public override string ToString()
        {
            return $"Radius: {Math.Round(Radius, 2)}\n" +
                $"Circumference: {Math.Round( Circumference, 2)}\n" +
                $"Area: {Math.Round(Area, 2)}\n";
        }

    }
}
