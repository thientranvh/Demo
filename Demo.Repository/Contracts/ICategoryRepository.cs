using System.Collections.Generic;
using Demo.Data.Models;

namespace Demo.Repository.Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Author> GetAllAuthorByBookLanguage(string language);
    }
}