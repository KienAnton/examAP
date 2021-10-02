using System;

namespace Exercise2
{
    public class Lion : Base
    {
        public new void Show()
        {
            Console.WriteLine($"Name: {Name}, Weight: {Weight}");
        }

        public void SetMe(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}