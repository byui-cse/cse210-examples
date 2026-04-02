using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AsyncDownloader;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("--- Async Downloader Project ---");

        BookDownloader downloader = new BookDownloader();

        // Gutenberg Book URLs
        string aliceUrl = "https://www.gutenberg.org/files/11/11-0.txt";
        string prideUrl = "https://www.gutenberg.org/files/1342/1342-0.txt";

        // Start both downloads simultaneously by initiating the tasks
        Task<string> aliceTask = downloader.DownloadBookAsync(aliceUrl, "Alice in Wonderland");
        Task<string> prideTask = downloader.DownloadBookAsync(prideUrl, "Pride and Prejudice");

        Console.WriteLine("\nWaiting for all downloads to complete...\n");

        // Use Task.WhenAll to wait for both to finish
        string[] results = await Task.WhenAll(aliceTask, prideTask);

        Console.WriteLine("\nAll downloads are finished.");
        Console.WriteLine($"Total books downloaded: {results.Length}");
        Console.WriteLine("Exiting program.");
    }
}
