using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using PatGG.Core.Repositories;
using PatGG.Domain.Entities;

namespace PatGG.Data.Repositories
{
    public class ItemRepository : IItemRepository<Item>
    {
        private readonly DbContext _dbContext;

        public ItemRepository
        (
            DbContext dbContext
        )
        {
            _dbContext = dbContext;
        }

        public Task Create(Item obj)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Item>> Retrieve()
        {
            throw new NotImplementedException();
        }

        public Task<Item> Retrieve(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Item obj)
        {
            throw new NotImplementedException();
        }
    }
}
