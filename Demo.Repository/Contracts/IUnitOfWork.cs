using System;
using System.Threading.Tasks;

namespace Demo.Repository.Contracts
{
    public interface IUnitOfWork: IDisposable
    {
        Task Commit();
    }
}