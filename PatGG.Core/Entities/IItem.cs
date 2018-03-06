using System;
using System.Collections.Generic;

namespace PatGG.Core.Entities
{
    public interface IItem
    {
        Guid Id { get; set; }
        IEnumerable<Guid> Paths { get; set; }
        IEnumerable<IField> Fields { get; set; }
    }
}
