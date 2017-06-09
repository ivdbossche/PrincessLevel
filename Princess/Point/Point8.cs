using System;
using System.Text.RegularExpressions;

namespace Princess.Point
{
    class Point8 : IPoint
    {
        public int Order => Int32.Parse(Regex.Match(GetType().Name, @"\d+").Value);
        public Position Position => new Position() { X = 9, Y = 6 };
    }
}