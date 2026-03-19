class Map : LibraryItem
{
    private string _location;
    private string _size;

    public string Location { get { return _location; } }
    public string Size { get { return _size; } }

    public Map(string name, string description, int id, int totalItems, int numberCheckedOut, string location, string size)
        : base(name, description, id, totalItems, numberCheckedOut)
    {
        _location = location;
        _size = size;
    }

    public override void Display()
    {
        Console.WriteLine($"ID: {_id}, Name: {_name}, Location: {_location}, Description: {_description}, Size: {_size}, Total: {_totalItems}, Checked Out: {_numberCheckedOut}");
    }

    public override string Serialize()
    {
        return $"Map|{_name}|{_description}|{_id}|{_totalItems}|{_numberCheckedOut}|{_location}|{_size}";
    }
}
