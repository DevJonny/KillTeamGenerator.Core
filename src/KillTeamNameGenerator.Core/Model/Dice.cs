using System;

namespace KillTeamNameGenerator.Core.Model
{
    public class Dice
    {
        public static int D10 => _random.Next(1, 10);
        public static int D6 => _random.Next(1, 6);
        
        public static int D66
        {
            get
            {
               var diceResult = int.Parse($"{D6}{D6}");

                return diceResult <= 16 
                        ? diceResult - 11 
                        : diceResult <= 26 
                            ? diceResult - 15 
                            : diceResult <= 36 
                                ? diceResult - 19 
                                : diceResult <= 46 
                                    ? diceResult - 23 
                                    : diceResult <= 56 
                                        ? diceResult - 27 
                                        : diceResult - 31;
            }
        }

        
        
        private static readonly Random _random = new Random();
    }
}