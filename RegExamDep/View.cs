using System.ComponentModel;

namespace RedExamDep;

public class View<T> : ViewService<T>
{
    public uint ViewID { get; set; }
    public string ViewName { get; set; }
    public T ViewInternalContent { get; set; }

    public View()
    {
    }

    public View(uint viewID, string viewName)
    {
        ViewID = viewID;
        ViewName = viewName;
    }

    public override void ViewInitialize(T content)
    {
        ViewInternalContent = content;
    }

    public override void ViewShow()
    {
        Console.WriteLine(ViewInternalContent);
    }

    public override void ViewHide()
    {
        
    }
    
    public uint GetViewID()
    {
        return ViewID;
    }
    

    public void PrintView()
    {
        Console.WriteLine($"View No {ViewID}  {ViewName}: .");
    }
}