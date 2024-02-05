using System.Net.Http.Headers;

var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Get,
    RequestUri = new Uri("https://vinted3.p.rapidapi.com/getSearch?country=pl&page=1&order=newest_first&keyword=Szary%20sweter%20m%C4%99ski%20Tommy%20Hilfiger%20rozmiar%20L"),
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