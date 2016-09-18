using PortableLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortableLibrary.Services
{
    public class SampleBooksService : IBooksService
    {
        private readonly List<Book> _books;

        public SampleBooksService()
        {
            _books = new List<Book>
            {
                new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press" },
                new Book { BookId = 2, Title = "Enterprise Services", Publisher = "Addison Wesley" }
            };
        }

        public Task AddBookAsync(Book book)
        {
            _books.Add(book);
            return Task.FromResult<object>(null);
        }

        public Task DeleteBookAsync(int bookId)
        {
            Book book = _books.Single(b => b.BookId == bookId);
            _books.Remove(book);
            return Task.FromResult<object>(null);
        }

        public Task<Book> GetBookByIdAsync(int id)
        {
            var book = _books.Find(b => b.BookId == id);
            return Task.FromResult(book);
        }

        public Task<IEnumerable<Book>> GetBooksAsync()
        {
            return Task.FromResult(_books as IEnumerable<Book>);
        }

        public async Task UpdateBookAsync(Book book)
        {
            await DeleteBookAsync(book.BookId);
            await AddBookAsync(book);
        }
    }
}
