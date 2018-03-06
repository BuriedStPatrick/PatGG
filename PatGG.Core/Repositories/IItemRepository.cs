using PatGG.Core.Entities;

namespace PatGG.Core.Repositories
{
    public interface IItemRepository<T> : IRepository<T> where T : IItem
    {
        
    }
}
