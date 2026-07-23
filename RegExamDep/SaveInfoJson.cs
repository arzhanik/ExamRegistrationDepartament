using System.Text.Json;

namespace RedExamDep;

public class SaveInfoJson<T> : ISaveService
{
    public string Days { get; set; }
    public Dictionary<DateOnly, ulong> DeserializedJsonData { get; set; }
    public event Action<string> messageSent;

    public void send(T content)
    {
        messageSent?.Invoke($"{content}");
    }

    public bool Serialize<T>(T obj)
    {
        if (obj == null)
        {
            Console.WriteLine("Empty object passed.");
            return false;
        }

        try
        {
            string json = JsonSerializer.Serialize(obj);

            File.WriteAllText("/home/arzhanik/RiderProjects/RegExamDep/RegExamDep/DataBaseExamDaysTable.json", json);
            return true;
        }
        catch (Exception exp)
        {
            Console.WriteLine("Writing info to file failed.");
        }
        Console.WriteLine("Writing info to file failed.");
        return false;
    }

    public T? Deserialize<T>()
    {
        T obj = default;
        try
        {
            Days = File.ReadAllText("/home/arzhanik/RiderProjects/RegExamDep/RegExamDep/DataBaseExamDaysTable.json");
            obj = JsonSerializer.Deserialize<T>(Days);
        }
        catch (Exception exp)
        {
            Console.WriteLine("Oh, nooo");
        }

        return obj;
    } 
}