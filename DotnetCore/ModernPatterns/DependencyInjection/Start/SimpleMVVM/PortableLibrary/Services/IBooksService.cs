﻿using PortableLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortableLibrary.Services
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetBooksAsync();
        Task<Book> GetBookByIdAsync(int id);
        Task AddBookAsync(Book book);
        Task DeleteBookAsync(int bookId);
        Task UpdateBookAsync(Book book);
    }
}
