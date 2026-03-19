using System.Collections.Generic;

class LibraryItemFactory
{
    private BookFactory _bookFactory;
    private AudioBookFactory _audioBookFactory;
    private DVDFactory _dvdFactory;
    private MapFactory _mapFactory;

    public LibraryItemFactory()
    {
        _bookFactory = new BookFactory();
        _audioBookFactory = new AudioBookFactory();
        _dvdFactory = new DVDFactory();
        _mapFactory = new MapFactory();
    }

    public LibraryItem CreateItem(string data)
    {
        string[] parts = data.Split("|");
        string type = parts[0];

        if (type == "Book")
        {
            return _bookFactory.Create(data);
        }
        else if (type == "AudioBook")
        {
            return _audioBookFactory.Create(data);
        }
        else if (type == "DVD")
        {
            return _dvdFactory.Create(data);
        }
        else if (type == "Map")
        {
            return _mapFactory.Create(data);
        }

        return null;
    }
}
