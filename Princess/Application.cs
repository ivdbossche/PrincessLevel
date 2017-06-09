using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Princess.Point;

namespace Princess
{
    public interface IApplication
    {
        void Run();
    }
    class Application : IApplication
    {
        private readonly IConfiguration _config;
        private readonly IEnumerable<IPoint> _points;
        private readonly ISolutionPosterService _solutionPosterService;

        public Application(IConfiguration config, IEnumerable<IPoint> points, ISolutionPosterService solutionPosterService)
        {
            _config = config;
            _points = points;
            _solutionPosterService = solutionPosterService;
        }
        public void Run()
        {
            Position[] solution = _points.OrderBy(o => o.Order).Take(_config.MaxRetries).Select(o => o.Position).ToArray();

            _solutionPosterService.PostSolution(_config.Teamname, solution);
        }
    }
}
