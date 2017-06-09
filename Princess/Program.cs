using System.Collections.Generic;
using System.Reflection;
using Autofac;

namespace Princess
{
    public struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        //public static string TestUrl = "http://www.example.com"; //use this to test sending POSTs

        public static string ProductionUrl = "http://mazeretreat.azurewebsites.net/solutions/"; // use this to POST actual solution
        #region

        //private const string Map =
        //    "############ ##...##...## ##.#.##.#.## ##.#.##.#.## S..#.##.#..F ##.#.##.#.## #1.#.##.#.1# ####....#### ############";

        //private const char Grass = '.';
        //private const char Key = 'F';
        //private const string Princess = "S";

        //private struct HorizontalBound
        //{
        //    public int LeftX { get; set; }
        //    public int RightX { get; set; }
        //}

        //private static string[] Rows;

        //private static int GetStarterRow()
        //{
        //    int i = 0;

        //    for (int idx = 0; idx < Rows.Length; idx++)
        //    {
        //        if (Rows[idx].Contains(Princess))
        //        {
        //            break;
        //        }
        //        i++;
        //    }

        //    return i;
        //}

        //private static Position GetStarterPosition()
        //{
        //    int y = GetStarterRow();
        //    int x = Rows[y].IndexOf(Princess, StringComparison.Ordinal);

        //    return new Position
        //    {
        //        X = x,
        //        Y = y
        //    };
        //}

        //private static Position[] GetSolution(string rawMapAscii)
        //{
        //    Position[] solution = new Position[] {

        //    };

        //    return solution;
        //}

        //private static readonly List<Position> PositionsAlreadyProcessed = new List<Position>();
        #endregion
        static void Main(string[] args)
        {
            #region

            //    Rows = Map.Split(' ');

            //    bool routeFound = false;

            //    Position starterPosition = GetStarterPosition();
            //    HorizontalBound horizontalBound = new HorizontalBound
            //    {
            //        LeftX = 0,
            //        RightX = Rows[0].Length - 1
            //    };

            //    Position currentPosition = starterPosition;
            //    int stepsDone = 0;
            //    do
            //    {
            //        if (currentPosition.X > horizontalBound.LeftX)
            //        {
            //            // Look left
            //            string row = Rows[currentPosition.Y];
            //            char c = row[currentPosition.X - 1];

            //            Position tempPosition = currentPosition;
            //            tempPosition.X -= 1;

            //            if (!PositionsAlreadyProcessed.Contains(tempPosition) &&  (c == Grass || c == Key))
            //            {
            //                currentPosition = tempPosition;
            //                PositionsAlreadyProcessed.Add(currentPosition);
            //                stepsDone++;
            //                if (c == Key)
            //                {
            //                    routeFound = true;
            //                }
            //            }
            //        }
            //        if (currentPosition.X < horizontalBound.RightX)
            //        {
            //            // Look right
            //            string row = Rows[currentPosition.Y];
            //            char c = row[currentPosition.X + 1];

            //            Position tempPosition = currentPosition;
            //            tempPosition.X += 1;

            //            if (!PositionsAlreadyProcessed.Contains(tempPosition) && (c == Grass || c == Key))
            //            {
            //                currentPosition = tempPosition;
            //                PositionsAlreadyProcessed.Add(currentPosition);
            //                stepsDone++;
            //                if (c == Key)
            //                {
            //                    routeFound = true;
            //                }
            //            }
            //        }
            //        if (currentPosition.Y > 0)
            //        {
            //            // Look up
            //            string row = Rows[currentPosition.Y - 1];
            //            char c = row[currentPosition.X];

            //            Position tempPosition = currentPosition;
            //            tempPosition.Y -= 1;

            //            if (!PositionsAlreadyProcessed.Contains(tempPosition) && (c == Grass || c == Key))
            //            {
            //                currentPosition = tempPosition;
            //                PositionsAlreadyProcessed.Add(currentPosition);
            //                stepsDone++;
            //                if (c == Key)
            //                {
            //                    routeFound = true;
            //                }
            //            }
            //        }
            //    } while (!routeFound);

            //    Console.WriteLine($"Key found at {currentPosition.X}, {currentPosition.Y}");
            //    Console.WriteLine($"Steps done: {stepsDone}");
            #endregion
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(typeof(Program).Assembly).AsImplementedInterfaces();

            var container = builder.Build();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }



        }
    }
}
