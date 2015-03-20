using System;

namespace Tetris
{
    public class Random
    {
        private const double a = 8503057;
        private const double m = 9834497;
        private double Rn { get; set; }

        public Random(int rn = 0)
        {
            if (rn < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                if (rn == 0)
                {
                    Rn = new System.Random().Next(int.MaxValue) + 1;
                }
                else
                {
                    Rn = rn;
                }
            }
        }

        public int Next(int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentOutOfRangeException();
            }
            Rn = a * Rn % m;
            return Convert.ToInt32(min + (max - min) * (Rn / m));
        }
    }
}