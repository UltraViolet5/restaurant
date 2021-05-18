using System;
using restaurant.utils;


namespace restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int x = Utils.GetRandom(1, 3);
                Console.WriteLine(x);
            }
            
        }
    }
}
