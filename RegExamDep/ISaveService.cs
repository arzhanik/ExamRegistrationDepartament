namespace RedExamDep;

public interface ISaveService
{
    event Action<string> messageSent;

    public bool Serialize<T>(T obj);
    public T? Deserialize<T>();
}