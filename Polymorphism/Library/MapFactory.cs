class MapFactory
{
    public Map Create(string data)
    {
        string[] parts = data.Split("|");
        // parts[0] is the type "Map"
        string name = parts[1];
        string description = parts[2];
        int id = int.Parse(parts[3]);
        int totalItems = int.Parse(parts[4]);
        int numberCheckedOut = int.Parse(parts[5]);
        string location = parts[6];
        string size = parts[7];

        return new Map(name, description, id, totalItems, numberCheckedOut, location, size);
    }
}
