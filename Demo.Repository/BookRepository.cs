using System.Collections.Generic;
using System.Linq;
using Demo.Data.Models;
using Demo.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Demo.Repository
{
    public class BookRepository: GenericRepository<Book>,IBookRepository
    {
        private readonly BookManagementContext _dbContext;
        
        public BookRepository(BookManagementContext context) : base(context)
        {
            this._dbContext = context;
        }

        public IEnumerable<Book> GetTopBookInMonth(int month, int count)
        {
            return (from b in this._dbContext.Book
                orderby b.Rating descending
                where b.ReleaseDate.Month.Equals(month)
                select b).Take(count);
        }
    }
}