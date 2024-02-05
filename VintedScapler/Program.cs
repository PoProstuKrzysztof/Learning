using HtmlAgilityPack;
using System.Xml;
using ScrapySharp.Extensions;
using Fizzler.Systems.HtmlAgilityPack;

using System.Net.Http.Headers;

using System.Net.Http.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using Newtonsoft.Json;

HttpClient client = new HttpClient();

client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "ee737b3b14msha75d8c55f6c9529p119a6ajsn129f97bc38b0");
client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "vinted3.p.rapidapi.com");

HttpResponseMessage message = await client.GetAsync("https://vinted3.p.rapidapi.com/getSellerProducts?country=pl&userId=103343316&page=1");
message.EnsureSuccessStatusCode();
string jsonContent = await message.Content.ReadAsStringAsync();

List<Product> products = JsonConvert.DeserializeObject<List<Product>>(jsonContent);

foreach (var product in products)
{
    Console.WriteLine($"Title: {product.Title}");
    Console.WriteLine($"Price: {product.Price?.Amount} {product.Price?.Currency}");
    Console.WriteLine($"Url: {product.Url}");
    Console.WriteLine();
}

static string SetUser()
{
    Console.WriteLine("Paste userId ");
    var userId = Console.ReadLine();
    if (string.IsNullOrEmpty(userId))
    {
        Console.WriteLine("No UserId was passed");
    }

    return userId;
}

async static void GetProducts()
{
    var userId = SetUser();
    var client = new HttpClient();
    var request = new HttpRequestMessage
    {
        Method = HttpMethod.Get,
        RequestUri = new Uri($"https://vinted3.p.rapidapi.com/getSellerProducts?country=pl&userId={userId}&page=1"),
        Headers =
    {
        { "X-RapidAPI-Key", "ee737b3b14msha75d8c55f6c9529p119a6ajsn129f97bc38b0" },
        { "X-RapidAPI-Host", "vinted3.p.rapidapi.com" },
    },
    };

    using (var response = await client.SendAsync(request))
    {
        response.EnsureSuccessStatusCode();
        var body = await response.Content.ReadAsStringAsync();
        Console.WriteLine(body);
    }
}

internal class Product
{
    public string? Title { get; set; }
    public Price? Price { get; set; }
    public string? Currency { get; set; }

    public string? Url { get; set; }
}

public struct Price
{
    public string? Amount { get; set; }
    public string? Currency { get; set; }
    public string? Discount { get; set; }
    public string? Fees { get; set; }
    public string? TotalAmount { get; set; }
}