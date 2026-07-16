using System.ComponentModel;

namespace RedExamDep;

public class View
{
    public uint ViewID { get; set; }
    public string ViewName { get; set; }
    public string ViewContent { get; set; }

    public View()
    {
    }

    public View(uint viewID, string viewName, string viewContent = "")
    {
        ViewID = viewID;
        ViewName = viewName;
        ViewContent = viewContent;
    }

    public uint GetViewID()
    {
        return ViewID;
    }

    public string GetContent()
    {
        return ViewContent;
    }

    public void AddContentInView(string content)
    {
        ViewContent = content;
    }

    public void PrintView()
    {
        Console.WriteLine($"View No {ViewID}  {ViewName}: {ViewContent}.");
    }
}