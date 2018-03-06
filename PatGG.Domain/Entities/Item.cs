using PatGG.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatGG.Domain.Entities
{
    public class Item : IItem
    {
        [Key]
        public Guid Id { get; set; }
        public IEnumerable<Guid> Paths { get; set; }
        public IEnumerable<IField> Fields { get; set; }
    }
}
