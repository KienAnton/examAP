using System;

namespace GeometryExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder();
            Console.WriteLine("Enter the demenstions of the cylinder:");
            Console.WriteLine("Radius: ");
            cylinder.Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            cylinder.Height = Convert.ToDouble(Console.ReadLine());
            cylinder.Process();
            cylinder = cylinder.Result();
            Console.WriteLine("Cylinder characteristics");
            Console.WriteLine($"Radius: {cylinder.Radius}, Height: {cylinder.Height}");
            Console.Write("Base: {00:0.##} | ", cylinder.BaseArea);
            Console.Write("LateralArea: {00:0.##} | ", cylinder.LateralArea);
            Console.Write("TotalArea : {00:0.##} | ", cylinder.TotalArea);
            Console.Write("Volume: {00:0.##}", cylinder.Volume);
        }
    }
}