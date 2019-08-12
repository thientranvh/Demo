using System.Collections.Generic;
using Demo.Data.Models;

namespace Demo.Repository.Contracts
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetTopBookInMonth(int month, int count);
    }
}