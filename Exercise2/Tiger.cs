using System;

namespace Exercise2
{
    public class Tiger: Base
    {
        public new void Show()
        {
            Console.WriteLine($"name: {Name}, weight: {Weight}");
        }

        public void SetMe(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}