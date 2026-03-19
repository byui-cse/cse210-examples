abstract class LibraryItem
{
    protected string _name;
    protected string _description;
    protected int _id;
    protected int _totalItems;
    protected int _numberCheckedOut;

    public LibraryItem(string name, string description, int id, int totalItems, int numberCheckedOut)
    {
        _name = name;
        _description = description;
        _id = id;
        _totalItems = totalItems;
        _numberCheckedOut = numberCheckedOut;
    }

    public int GetTotalItems()
    {
        return _totalItems;
    }

    public void CheckOut()
    {
        if (_numberCheckedOut < _totalItems)
        {
            _numberCheckedOut++;
        }
        else
        {
            Console.WriteLine($"{_name} is not available for checkout.");
        }
    }

    public void CheckIn()
    {
        if (_numberCheckedOut > 0)
        {
            _numberCheckedOut--;
        }
    }

    public abstract void Display();

    public abstract string Serialize();
}
