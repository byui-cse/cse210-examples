public class Source {

    private string _name = "";
    private string _url = "";

    public Source(string name, string url=""){
        _name = name;
        _url = url;
    }

    public string Stringify()
    {
        return $"{_name} {_url}";
    }

}