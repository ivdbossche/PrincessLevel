using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Princess
{
    class SolutionPost
    {
        public string TeamName { get; set; }
        public string MazeId { get; set; }
        public string Solution { get; set; }

        public SolutionPost(string teamName, string mazeId, Position[] solution)
        {
            TeamName = teamName;
            MazeId = mazeId;
            Solution = FormatSolution(solution);
        }

        private string FormatSolution(Position[] solution)
        {
            StringBuilder formattedSolutionBuilder = new StringBuilder();

            foreach (var position in solution)
            {
                formattedSolutionBuilder.Append(position.X);
                formattedSolutionBuilder.Append(',');
                formattedSolutionBuilder.Append(position.Y);
                formattedSolutionBuilder.Append(';');
            }

            formattedSolutionBuilder.Remove(formattedSolutionBuilder.Length - 1, 1);

            return formattedSolutionBuilder.ToString();
        }

    }
}
