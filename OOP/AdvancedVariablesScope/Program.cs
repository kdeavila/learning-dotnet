Book book = new Book("Cien años de soledad", "Gabriel García Márquez");
book.PrintSummary();
Console.WriteLine($"Lenght title: {book.GetTitleLength()}");

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    { 
        Title = title;
        Author = author;
    }

    public void PrintSummary()
    {
        string summary = $"{Title} by {Author}";
        Console.WriteLine(summary);
    }

    public int GetTitleLength()
    {
        string titleLenghtWitoutSpaces = Title.Replace(" ", "");
        return titleLenghtWitoutSpaces.Length;
    }
}