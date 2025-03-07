namespace book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Egri Csillagok", "Gárdonyi Géza",400, 1901);
            Book b2 = new Book("Bogyó és Babóca labdázik", "Bartos Erika", 48, 2025);
            Book b3 = new Book("Egy ropi naplója", "Jeff Kinney", 224, 2007);
            Book[] books = [b1, b2, b3];
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            b1.EditBookData();
            b1.GetBookByTitle(books, b1.Title);
            b2.EditBookData();
            b2.GetBookByTitle(books, b2.Title);
            b3.EditBookData();
            b3.GetBookByTitle(books, b3.Title);
            b1.GetBookByTitle(books,"alma");
        }
    }
}
