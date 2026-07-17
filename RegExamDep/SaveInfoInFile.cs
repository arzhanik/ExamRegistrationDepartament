namespace RedExamDep;

public class SaveInfoInFile<T> : ISaveService
{
    public event Action<string> messageSent;

    public void send(T content)
    {
        messageSent?.Invoke($"content");
    }
    public void AddNewUser(User user)
    {
        
    }

    public void AddExamDay(DateOnly day, ulong userSocialCardNumber)
    {
        
    }
}