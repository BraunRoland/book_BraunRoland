namespace book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Egri Csillagok", "Gárdonyi Géza",400, 1901);
            Book[] books = [b1];
            Console.WriteLine(b1);
           // b1.EditBookData();
            b1.GetBookByTitle(books, b1.Title);
            b1.GetBookByTitle(books,"alma");
        }
    }
}
