namespace Princess
{
    public interface IConfiguration
    {
        string ProductionUrl { get; }
        string Teamname { get; }
        int MaxRetries { get; }
        string GenerateGuid();
    }
}