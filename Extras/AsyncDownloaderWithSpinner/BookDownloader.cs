using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncDownloaderWithSpinner;

public class BookDownloader
{
    private HttpClient _client;

    public BookDownloader()
    {
        _client = new HttpClient();
    }

    public async Task<string> DownloadBookAsync(string url, string bookTitle)
    {
        // Don't print "starting" here, to avoid interfering with the spinner in Main
        string content = await _client.GetStringAsync(url);
        return content;
    }
}
