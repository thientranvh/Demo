using System.Collections.Generic;
using Demo.Data.Models;

namespace Demo.Repository.Contracts
{
    public interface IAuthorRepository
    {
        IEnumerable<Book> GetAllAuthorByBookLanguage(string language);
    }
}