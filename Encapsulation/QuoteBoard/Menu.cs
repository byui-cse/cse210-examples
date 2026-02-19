public class Menu
{
    Board _board;

    public Menu(Board board)
    {
        _board = board;
    }

    public void Display()
    {
        string response = "";
        string[] options= {"A","S","Q","F","R"};
        while(response != "Q"){
            while(options.Contains(response)==false){
                Console.Write("[A]dd quote:\n[S]how quotes\n[F]ind Quotes by Author\n[R]andom Quote\n[Q]uit\n\nWhat do you want to do? ");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
            }
            switch(response){
                case "Q":
                    Environment.Exit(0);
                    break;
                case "A":
                    Console.Write("Please enter your quote: ");
                    string quote = Console.ReadLine() ?? String.Empty;
                    Console.Write("Please enter your author: ");
                    string author = Console.ReadLine() ?? String.Empty;
                    Console.Write("Please enter your source: ");
                    string source = Console.ReadLine() ?? String.Empty;
                    Console.Write("Please enter your source url: ");
                    string sourceUrl = Console.ReadLine() ?? String.Empty;                    

                    _board.AddQuote(new Quote(author,quote,new Source(source, sourceUrl)));
                    break;
                case "S":
                    _board.ShowQuotes();
                    break;
                case "F":
                    Console.Write("Please enter your author: ");
                    author = Console.ReadLine() ?? String.Empty;
                    _board.FindQuotesByAuthor(author); 
                    break;               
                case "R":
                    _board.GetRandomQuote();
                    break;
            }
            response = "";
        }
    }


}