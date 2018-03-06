using PatGG.Api.ViewModels;
using PatGG.Core.Entities;
using PatGG.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatGG.Api
{
    public class MockItemRepository : IItemRepository<IItem>
    {
        public Task Create(IItem obj)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IItem>> Retrieve()
        {
            var homeItemId = Guid.NewGuid();
            return Task.FromResult<IEnumerable<IItem>>(new List<ItemViewModel>()
                {
                    new ItemViewModel
                    {
                        Id = homeItemId,
                        Fields = new FieldViewModel[]
                        {
                            new FieldViewModel
                            {
                                Id = Guid.NewGuid(),
                                Key = "Name",
                                Value = "Home",
                                Paths = new List<Guid>()
                                {
                                    homeItemId
                                }
                            }
                        }
                    }
                });
        }

        public Task<IItem> Retrieve(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(IItem obj)
        {
            throw new NotImplementedException();
        }
    }
}
