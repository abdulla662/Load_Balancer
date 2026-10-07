public static class BackendServers
{
    public static readonly List<string> Servers = new()
    {
        Environment.GetEnvironmentVariable("BACKEND1_URL") ?? "http://localhost:5001",
        Environment.GetEnvironmentVariable("BACKEND2_URL") ?? "http://localhost:5002",
        Environment.GetEnvironmentVariable("BACKEND3_URL") ?? "http://localhost:5003",
    };

    private static int _lastIndex = -1;

    public static string GetNextServer()
    {
        _lastIndex = (_lastIndex + 1) % Servers.Count;
        return Servers[_lastIndex];
    }
}
