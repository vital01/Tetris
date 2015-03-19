using System;

namespace Tetris
{
    public class Random
    {
        private const double a = 614657;
        private const double m = 1336337;
        private double Rn { get; set; }

        public Random(int rn = -1)
        {
            if (rn == -1)
            {
                Rn = new System.Random().Next(Int32.MaxValue);
            }
            else
            {
                Rn = rn;
            }
        }

        public int Next(int min, int max)
        {
            Rn = a * Rn % m;
            return Convert.ToInt32(min + (max - min) * (Rn / m));
        }
    }
}