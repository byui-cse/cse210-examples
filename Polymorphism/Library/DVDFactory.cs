class DVDFactory
{
    public DVD Create(string data)
    {
        string[] parts = data.Split("|");
        // parts[0] is the type "DVD"
        string name = parts[1];
        string description = parts[2];
        int id = int.Parse(parts[3]);
        int totalItems = int.Parse(parts[4]);
        int numberCheckedOut = int.Parse(parts[5]);
        string producer = parts[6];

        return new DVD(name, description, id, totalItems, numberCheckedOut, producer);
    }
}
