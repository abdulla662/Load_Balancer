var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddHttpClient();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Load Balancer API", Version = "v1",
        Description = "Round-robin load balancer distributing requests across 3 backend servers." });
});

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"); c.RoutePrefix = string.Empty; });
app.MapControllers();
app.MapGet("/health", () => Results.Ok(new { status = "healthy", backends = BackendServers.Servers }));
app.Run();
