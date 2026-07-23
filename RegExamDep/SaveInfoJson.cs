using System.Text.Json;

namespace RedExamDep;

public class SaveInfoJson<T> : ISaveService
{
    public string Days { get; set; }
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
            Console.WriteLine("Serialize");

            string json = JsonSerializer.Serialize(obj);

            File.WriteAllText("/home/arzhanik/RiderProjects/RegExamDep/RegExamDep/DataBaseExamDaysTable.json", json);
            Console.WriteLine(" called");

            return true;
        }
        catch (Exception exp)
        {
            Console.WriteLine("Writing info to file failed.");
        }
        Console.WriteLine("Writing info to file failed.");
        return false;
    }

    public void Deserialize<T>()
    {
        Days = File.ReadAllText("DataBaseExamDaysTable.json");
    } 
}