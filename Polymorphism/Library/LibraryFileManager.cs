using System.IO;
using System.Collections.Generic;

class LibraryFileManager
{
    private string _filename;
    private LibraryItemFactory _factory;

    public LibraryFileManager(string filename)
    {
        _filename = filename;
        _factory = new LibraryItemFactory();
    }

    public void Save(List<LibraryItem> items)
    {
        using (StreamWriter writer = new StreamWriter(_filename))
        {
            foreach (LibraryItem item in items)
            {
                writer.WriteLine(item.Serialize());
            }
        }
    }

    public List<LibraryItem> Load()
    {
        List<LibraryItem> items = new List<LibraryItem>();

        if (!File.Exists(_filename))
        {
            return items;
        }

        string[] lines = File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            LibraryItem item = _factory.CreateItem(line);
            if (item != null)
            {
                items.Add(item);
            }
        }

        return items;
    }
}
