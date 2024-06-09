using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace MinimalAPI;

public class IndexModel : PageModel
{
    private readonly IHttpClientFactory _httpClientFactory;

    public IndexModel(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [BindProperty]
    public IEnumerable<Fruit> FruitModels { get; set; }

    public async Task OnGet()
    {
        var httpClient = _httpClientFactory.CreateClient("FruitApi");

        HttpResponseMessage response = await httpClient.GetAsync("");

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStreamAsync();
            var fruits = await JsonSerializer.DeserializeAsync<IEnumerable<Fruit>>(content);
        }
    }
}