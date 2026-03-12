class DVD : LibraryItem
{
    private string _producer;

    public string Producer { get { return _producer; } }

    public DVD(string name, string description, int id, int totalItems, int numberCheckedOut, string producer)
        : base(name, description, id, totalItems, numberCheckedOut)
    {
        _producer = producer;
    }

    public override void Display()
    {
        Console.WriteLine($"ID: {_id}, Name: {_name}, Producer: {_producer}, Description: {_description}, Total: {_totalItems}, Checked Out: {_numberCheckedOut}");
    }
}
