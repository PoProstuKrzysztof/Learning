var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddHttpClient("FruitApi", httpClient =>
{
    httpClient.BaseAddress = new Uri("https://www.example.com");
});

var app = builder.Build();
app.MapGet("/", () => "Hello World!");

app.Run();