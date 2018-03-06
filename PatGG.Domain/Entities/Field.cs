using PatGG.Core.Entities;
using System;
using System.Collections.Generic;

namespace PatGG.Domain.Entities
{
    public class Field : IField
    {
        public Guid Id { get; set; }
        public IEnumerable<Guid> Paths { get; set; }
        public string Key { get; set; }
        public dynamic Value { get; set; }
        public IEnumerable<IField> Fields { get; set; }
    }
}
