using System;

namespace Exercise2
{
    public class Base
    {
        public double Weight { get; set; }
        public string Name { get; set; }

        public void Show()
        {
        }

        public void SetMe(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }
    }
}