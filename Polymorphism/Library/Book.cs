class Book : LibraryItem
{
    private int _numberOfPages;
    private string _author;

    public int NumberOfPages { get { return _numberOfPages; } }
    public string Author { get { return _author; } }

    public Book(string name, string description, int id, int totalItems, int numberCheckedOut, int numberOfPages, string author)
        : base(name, description, id, totalItems, numberCheckedOut)
    {
        _numberOfPages = numberOfPages;
        _author = author;
    }

    public override void Display()
    {
        Console.WriteLine($"ID: {_id}, Name: {_name}, Author: {_author}, Description: {_description}, Pages: {_numberOfPages}, Total: {_totalItems}, Checked Out: {_numberCheckedOut}");
    }

    public override string Serialize()
    {
        return $"Book|{_name}|{_description}|{_id}|{_totalItems}|{_numberCheckedOut}|{_numberOfPages}|{_author}";
    }
}