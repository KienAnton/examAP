using System;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var lion = new Lion();
            var tiger = new Tiger();
            lion.SetMe("Lion", 100);
            tiger.SetMe("Tiger", 200);
            lion.Show();
            tiger.Show();
        }
    }
}