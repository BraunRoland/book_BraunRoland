using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    internal class Book
    {
        private string title;
        private string author;
        private int pageCount;
        private int releaseYear;



        public Book(string title, string author, int pageCount, int releaseYear)
        {
            this.title = title;
            this.author = author;
            this.pageCount = pageCount;
            this.releaseYear = releaseYear;
        }

        public string Title { get => title;}
        public string Author { get => author;}
        public int PageCount { get => pageCount;}
        public int ReleaseYear { get => releaseYear;}

        public void EditBookData()
        {
            Console.Write("Add meg a Könyv nevét: ");
            title = Console.ReadLine();
            Console.Write("Add meg a Könyv szerzőjét: ");
            author = Console.ReadLine();
            Console.Write("Add meg a Könyv oldalszámát: ");
            pageCount = int.Parse(Console.ReadLine());
            Console.Write("Add meg a Könyv kiadási évét: ");
            releaseYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Sikeres módósítás!");
            this.ToString();
        }

        public override string ToString()
        {
            return $"{author}-{title}: |{releaseYear}|{pageCount} oldal";
        }
    }
}
