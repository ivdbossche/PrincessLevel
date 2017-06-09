using System;
using System.Text.RegularExpressions;

namespace Princess.Point
{
    class Point5 : IPoint
    {
        public int Order => Int32.Parse(Regex.Match(GetType().Name, @"\d+").Value);
        public Position Position => new Position() { X = 2, Y = 6 };
    }
}