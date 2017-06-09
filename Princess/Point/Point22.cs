using System;
using System.Text.RegularExpressions;

namespace Princess.Point
{
    class Point22 : IPoint
    {
        private readonly ISolver _solver;

        public Point22(ISolver solver)
        {
            _solver = solver;
        }
        public int Order => Int32.Parse(Regex.Match(GetType().Name, @"\d+").Value);
        public Position Position => new Position() { X = _solver.X, Y = _solver.Y };
    }
}