using System;
using System.Collections.Generic;
using PatGG.Core.Entities;

namespace PatGG.Api.ViewModels
{
    public class FieldViewModel : IField
    {
        public string Key { get; set; }
        public dynamic Value { get; set; }
        public Guid Id { get; set; }
        public IEnumerable<Guid> Paths { get; set; }
        public IEnumerable<IField> Fields { get; set; }
    }
}
