namespace Princess.Point
{
    class Point10 : IPoint
    {
        public int Order => 10;
        public Position Position => new Position() { X = 9, Y = 4 };
    }
}