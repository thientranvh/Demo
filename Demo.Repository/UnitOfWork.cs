using System.Threading.Tasks;
using Demo.Data.Models;
using Demo.Repository.Contracts;

namespace Demo.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly BookManagementContext _dbContext;

        public UnitOfWork(BookManagementContext context)
        {
            this._dbContext = context;
            this.BookRepository = new BookRepository(this._dbContext);
        }

        public BookRepository BookRepository { get; set; }

        public void Dispose()
        {
            this._dbContext.Dispose();
        }

        public async Task Commit()
        {
            await this._dbContext.SaveChangesAsync();
        }
    }
}