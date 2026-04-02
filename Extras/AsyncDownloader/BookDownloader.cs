using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncDownloader;

public class BookDownloader
{
    private HttpClient _client;

    public BookDownloader()
    {
        _client = new HttpClient();
    }

    public async Task<string> DownloadBookAsync(string url, string bookTitle)
    {
        Console.WriteLine($"Starting download for: {bookTitle}...");
        
        string content = await _client.GetStringAsync(url);
        
        Console.WriteLine($"Finished download for: {bookTitle} ({content.Length} characters).");
        return content;
    }
}
