using System;
using System.Text.RegularExpressions;

namespace Princess.Point
{
    class Point1 : IPoint
    {
        public int Order => Int32.Parse(Regex.Match(GetType().Name, @"\d+").Value);
        public Position Position => new Position() { X = 0, Y = 4 };
    }
    
}
