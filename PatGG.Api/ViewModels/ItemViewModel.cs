using PatGG.Core.Entities;
using System;
using System.Collections.Generic;

namespace PatGG.Api.ViewModels
{
    public class ItemViewModel : IItem
    {
        public Guid Id { get; set; }
        public IEnumerable<Guid> Paths { get; set; }
        public IEnumerable<IField> Fields { get; set; }
    }
}
