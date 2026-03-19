using System.Collections.Generic;

class BookFactory
{
    public Book Create(string data)
    {
        string[] parts = data.Split("|");
        // parts[0] is the type "Book"
        string name = parts[1];
        string description = parts[2];
        int id = int.Parse(parts[3]);
        int totalItems = int.Parse(parts[4]);
        int numberCheckedOut = int.Parse(parts[5]);
        int numberOfPages = int.Parse(parts[6]);
        string author = parts[7];

        return new Book(name, description, id, totalItems, numberCheckedOut, numberOfPages, author);
    }
}
