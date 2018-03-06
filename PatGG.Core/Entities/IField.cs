namespace PatGG.Core.Entities
{
    public interface IField : IItem
    {
        string Key { get; set; }
        dynamic Value { get; set; }
    }
}
