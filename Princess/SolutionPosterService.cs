using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace Princess
{
    interface ISolutionPosterService
    {
        void PostSolution(string teamName, Position[] solution);
    }
    class SolutionPosterService: ISolutionPosterService
    {
        private readonly IConfiguration _configuration;
        private RestClient client { get; set; }
        public SolutionPosterService(IConfiguration configuration)
        {
            _configuration = configuration;
            client = new RestClient(_configuration.ProductionUrl);
        }
        public void PostSolution(string teamName, Position[] solution)
        {
            Console.WriteLine("Constructing POST...");
            SolutionPost solutionPost = new SolutionPost(teamName, _configuration.GenerateGuid(), solution);
            var json = JsonConvert.SerializeObject(solutionPost);
            Console.WriteLine("Json for post: " + json);
            var restRequest = new RestRequest("POST");
            restRequest.Resource = _configuration.GenerateGuid();
            restRequest.AddParameter("application/json", json, ParameterType.RequestBody);
            restRequest.Method = Method.POST;
            Console.WriteLine("Sending POST...");
            var response = client.Execute(restRequest);
            Console.WriteLine("Response after post: " + response.Content);
        }
    }
}
