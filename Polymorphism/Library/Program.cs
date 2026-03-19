using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string filename = "library.txt";
        LibraryFileManager fileManager = new LibraryFileManager(filename);

        List<LibraryItem> items = fileManager.Load();

        // If no items were loaded from the file, create the default list
        if (items.Count == 0)
        {
            Console.WriteLine("No library data found. Creating default items...");

            List<Book> books = new List<Book>
            {
                new Book("C# Basics", "Intro to C#", 1, 5, 1, 300, "Jane Doe"),
                new Book("Advanced C#", "Deep dive into C#", 2, 3, 0, 450, "John Sharp"),
                new Book("OOP Concepts", "Understanding Object-Oriented Programming", 3, 4, 2, 280, "Sarah Codewell")
            };

            List<AudioBook> audioBooks = new List<AudioBook>
            {
                new AudioBook("The Great Audio Adventure", "An exciting journey", 4, 3, 2, 2.5, "John Smith", new List<string> { "Alice", "Bob" }),
                new AudioBook("C# Audio Course", "Learn by listening", 5, 2, 1, 3.0, "Emily Syntax", new List<string> { "Tom", "Nina" }),
                new AudioBook("History of Computing", "A spoken documentary", 6, 1, 0, 1.5, "Alan Retrospect", new List<string> { "Dr. Tech", "Narrator Joe" })
            };

            List<Map> maps = new List<Map>
            {
                new Map("World Map", "Geographical map", 7, 2, 0, "Global", "Large"),
                new Map("City Transit Map", "Map of public transportation routes", 8, 5, 1, "Metroville", "Medium")
            };

            List<DVD> dvds = new List<DVD>
            {
                new DVD("C# Movie", "Learn C# visually", 9, 4, 1, "Tech Films"),
                new DVD("Design Patterns Explained", "Understand design patterns visually", 10, 3, 0, "CodeMedia"),
                new DVD("Introduction to Databases", "Database basics for beginners", 11, 2, 1, "LearnIt Studios")
            };

            items.AddRange(books);
            items.AddRange(audioBooks);
            items.AddRange(maps);
            items.AddRange(dvds);

            // Save the initial list to the file
            fileManager.Save(items);
        }
        else
        {
            Console.WriteLine("Library data loaded from file.");
        }

        // Display all the library items
        Console.WriteLine("\nAll Library Items:");
        foreach (LibraryItem item in items)
        {
            item.Display();
        }

        // Count all the library items
        int totalItems = 0;
        foreach (LibraryItem item in items)
        {
            totalItems += item.GetTotalItems();
        }
        Console.WriteLine($"\nTotal Library Items: {totalItems}");
    }
}
