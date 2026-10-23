
using System;

public class Book : IDisposable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public static string LibraryName { get; set; } = "Thu vien Quoc gia";
    public static int TotalBooks { get; private set; } = 0;

    public Book() : this("Chua ro", "Chua ro", 0)
    {
    }

    public Book(string title, string author) : this(title, author, 0)
    {
    }

    public Book(string title, string author, double price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
        TotalBooks++;
    }

    public void DisplayInfo()
    {
        Console.WriteLine(
            $"{Title} - {Author}, Gia: {Price} VND, Thu vien: {LibraryName}");
    }

    ~Book()
    {
        Console.WriteLine($"Book [{Title}] da bi huy (Destructor).");
    }

    public void Dispose()
    {
        Console.WriteLine(
            $"Da giai phong tai nguyen cho [{Title}] (Dispose).");
    }
}
