using System.Collections.Generic;

class AudioBookFactory
{
    public AudioBook Create(string data)
    {
        string[] parts = data.Split("|");
        // parts[0] is the type "AudioBook"
        string name = parts[1];
        string description = parts[2];
        int id = int.Parse(parts[3]);
        int totalItems = int.Parse(parts[4]);
        int numberCheckedOut = int.Parse(parts[5]);
        double duration = double.Parse(parts[6]);
        string author = parts[7];
        string[] castParts = parts[8].Split(",");
        List<string> cast = new List<string>(castParts);

        return new AudioBook(name, description, id, totalItems, numberCheckedOut, duration, author, cast);
    }
}
