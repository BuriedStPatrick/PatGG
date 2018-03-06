using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatGG.Core.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> Retrieve();
        Task<T> Retrieve(Guid id);
        Task Create(T obj);
        Task Update(T obj);
        Task Delete(Guid id);
    }
}
