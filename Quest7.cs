public class Book
{
    public string Title { set; }
}

Book book = new Book();
book.Title = "Hello Vamp!"
Console.WriteLine(book.Title);