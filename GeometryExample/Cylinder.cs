using System;
using System.Collections;

namespace GeometryExample
{
    public class Cylinder
    {
        public double Radius { get; set; }
        public double BaseArea { get; set; }
        public double LateralArea { get; set; }
        public double TotalArea { get; set; }
        public double Volume { get; set; }
        public double Height { get; set; }

        public Cylinder()
        {
        }

        public Cylinder(double radius, double baseArea, double lateralArea, double totalArea, double volume, double height)
        {
            Radius = radius;
            BaseArea = baseArea;
            LateralArea = lateralArea;
            TotalArea = totalArea;
            Volume = volume;
            Height = height;
        }
        
        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Radius + Height);
            Volume = Math.PI * Radius * Radius * Height;
        }
        
        public Cylinder Result()
        {
            var cylinder = new Cylinder(Radius, BaseArea, LateralArea, TotalArea, Volume, Height);
            return cylinder;
        }
    }
}