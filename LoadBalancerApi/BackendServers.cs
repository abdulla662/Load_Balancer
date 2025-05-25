
public static class BackendServers
{
    public static readonly List<string> Servers = new List<string>
    {
        "http://localhost:5001",
        "http://localhost:5002",
        "http://localhost:5003"
    };

    private static int lastIndex = -1;

    public static string GetNextServer()
    {
        lastIndex = (lastIndex + 1) % Servers.Count;
        return Servers[lastIndex];
    }
}
