using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AsyncDownloaderWithSpinner;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("--- Async Downloader With Spinner Project ---");

        BookDownloader downloader = new BookDownloader();

        // Gutenberg Book URLs
        string aliceUrl = "https://www.gutenberg.org/files/11/11-0.txt";
        string prideUrl = "https://www.gutenberg.org/files/1342/1342-0.txt";

        // Start both downloads simultaneously
        Task<string> aliceTask = downloader.DownloadBookAsync(aliceUrl, "Alice in Wonderland");
        Task<string> prideTask = downloader.DownloadBookAsync(prideUrl, "Pride and Prejudice");

        Console.Write("\nDownloading books ");

        // Spinner logic
        int counter = 0;
        string[] spinnerChars = { "/", "-", "\\", "|" };

        // While either task is not complete, show the spinner
        while (!aliceTask.IsCompleted || !prideTask.IsCompleted)
        {
            Console.Write(spinnerChars[counter % 4]);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            
            counter++;
            
            // Wait a small amount of time to make the spinner visible but responsive
            await Task.Delay(100);
        }

        // Wait for results to be available
        string aliceContent = await aliceTask;
        string prideContent = await prideTask;

        Console.WriteLine("\n\nAll downloads are finished.");
        Console.WriteLine($"Alice in Wonderland characters: {aliceContent.Length}");
        Console.WriteLine($"Pride and Prejudice characters: {prideContent.Length}");
        Console.WriteLine("Exiting program.");
    }
}
