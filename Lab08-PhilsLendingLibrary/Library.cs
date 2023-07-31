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
    public class Library : ILibrary
    {
        private Dictionary<string, Book> Storage;

        public int Count { get; set; }
        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            Book newBook = new Book(title, $"{firstName} {lastName}", numberOfPages);

            Storage.Add(newBook.Title, newBook);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // call the generic version of the method
            return this.GetEnumerator();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            var result = Storage.Values;
            foreach (Book book in result)
            {
                yield return book;
            }
        }

        public Book Borrow(string title)
        {
            Book returnedBook = Storage.GetValueOrDefault(title);

            return returnedBook;
        }
        public void Return(Book book)
        {
            Storage.Add(book.Title, book);
        }

        public Book Search(string title)

        {
            bool result = Storage.ContainsKey(title);
            if (result == true)
            {
                return Storage[title];
            }
            return null;
        }
    }

}
