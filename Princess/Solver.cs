using System;

namespace Princess
{
    class Solver : ISolver
    {
        private readonly Random _random;

        public Solver()
        {
            _random = new Random();
        }

        public int X => _random.Next(0, 25);
        public int Y => _random.Next(0, 25);
    }
}