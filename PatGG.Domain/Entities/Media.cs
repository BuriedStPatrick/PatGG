using PatGG.Core.Entities;

namespace PatGG.Domain.Entities
{
    public class Media : Item, IMedia
    {
        public byte[] Data { get; set; }
    }
}
