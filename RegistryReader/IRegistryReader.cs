namespace RegistryReader
{
    public interface IRegistryReader
    {
        string ReadRegistryKey(string path, string property, string defaultValue);
    }
}