namespace Princess.Point
{
    class Point12 : IPoint
    {
        public int Order => 12;
        public Position Position => new Position() { X = 11, Y = 4 };
    }
}