class AudioBook : LibraryItem
{
    private double _duration;
    private string _author;
    private List<string> _cast;

    public double Duration { get { return _duration; } }
    public string Author { get { return _author; } }
    public List<string> Cast { get { return _cast; } }

    public AudioBook(string name, string description, int id, int totalItems, int numberCheckedOut, double duration, string author, List<string> cast)
        : base(name, description, id, totalItems, numberCheckedOut)
    {
        _duration = duration;
        _author = author;
        _cast = cast;
    }

    public override void Display()
    {
        Console.WriteLine($"ID: {_id}, Name: {_name}, Author: {_author}, Description: {_description}, Duration: {_duration}, Total: {_totalItems}, Checked Out: {_numberCheckedOut}");
    }
}
