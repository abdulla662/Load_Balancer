
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

[Route("api/[controller]")]
[ApiController]
public class LoadBalancerController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public LoadBalancerController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    [HttpGet("forward")]
    public async Task<IActionResult> Forward()
    {
        var server = BackendServers.GetNextServer();
        var url = $"{server}/api/test";

        try
        {
            var response = await _httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            return Content(content, "application/json");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"❌ Failed to reach server: {ex.Message}");
        }
    }
}
