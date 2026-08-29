namespace CodeSkwelaFormBuilder.Blazor.Shared
{
    public interface IFormControlSerializer
    {
        string Serialize();
        static abstract Dictionary<string, object> Deserialize(string serializedParameters);
    }
}
