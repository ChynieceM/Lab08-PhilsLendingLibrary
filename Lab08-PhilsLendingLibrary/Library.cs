using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab08_PhilsLendingLibrary
{
    internal class Library : ILibrary
    {
        private Dictionary<string, Book> Storage;

        public Library()
        {
            Storage = new Dictionary<string, Book>();

            Book book1 = new Book("Harry Potter", "Some Woman", 100);
            Book book2 = new Book("Americanah", "Chimamanda", 100);
            Book book3 = new Book("berserk", "Kentura", 100);

            Storage.Add(book1.Title, book1);
            Storage.Add(book2.Title, book2);
            Storage.Add(book3.Title, book3);
        }

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            var book = new Book(title, $"{firstName} {lastName}", numberOfPages);
            Storage.Add(title, book);
        }

        public Book Borrow(string title)
        {
            if (Storage.ContainsKey(title))
            {
                var book = Storage[title];
                Storage.Remove(title);
                return book;
            }
            return null;
        }

        public void Return(Book book)
        {
            Storage.Add(book.Title, book);
        }

        public Book Search(string title)
        {
            if (Storage.ContainsKey(title))
            {
                return Storage[title];
            }

            return null;
        }

        public int Count => Storage.Count;

        public IEnumerator<Book> GetEnumerator()
        {
            return Storage.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
