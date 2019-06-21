using System;

namespace KTNameGenerator.Core
{
    public class Dice
    {
        public static int D10 => _random.Next(1, 10);
        public static int D6 => _random.Next(1, 6);
        
        private static readonly Random _random = new Random();
    }
}