namespace RedExamDep;

public interface ISaveService
{
    event Action<string> messageSent;

    public bool Serialize<T>(T obj);
    public void Deserialize<T>();
}