
===============================

## Board

-------------------------------
    - _quotes : List<Quote> 
-------------------------------
    + ShowQuotes() : void
    + AddQuotes(quote : Quote) : void
    + GetRandomQuote() : void
    + FindQuotesByAuthor(author : string) : void
    - NicePrint(item : string) : void
===============================

ShowQuotes - Displays all quotes

AddQuotes - Adds a quote to the list

GetRandomQuote - Displays a random quote

FindQuotesByAuthor - Displays all quotes by that author

NicePrint - Displays information nicely by adding formatting around the quotes


===============================

## Quote

-------------------------------
    - _author : string 
    - _quote : string 
    - _source : Source 
-------------------------------
    + Quote(person : string, quote : string, source : Source)
    + HasAuthor(name : string) : bool
    + GetQuote() : string
===============================

Quote - creates a quote

HasAuthor - returns true if the name is contained in the author

GetQuote - returns a string representation of the quote, author, and source


===============================

## Source

-------------------------------
    - _name : string 
    - _url : string 
-------------------------------
    + Source(name : string, [url]: string)
    + Stringify : string
===============================

Source - creates a source with the name and url, url is optional

Stringify - returns a string version of the source

===============================

## Menu

-------------------------------
    - _board : Board 
-------------------------------
    + Display() : void
===============================

Display - asks what they want to do:
 
* [A]dd quote:
* [S]how quotes
* [F]ind Quotes by Author
* [R]andom Quote
* [Q]uit

Based on their response, call the correct methods. [A]dd quote requires Menu to gather all necessary information to create the quote and then call the correct methods.