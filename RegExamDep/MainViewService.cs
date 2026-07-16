namespace RedExamDep;

public class MainViewService : ViewService<View>
{
    public View CurrentView;
    
    public MainViewService(uint viewID, string viewName)
    {
        CurrentView = new View(viewID, viewName);
    }

    public override void ViewInitialize()
    {
        throw new NotImplementedException();
    }

    public override void ViewShow()
    {
        CurrentView.PrintView();
        ViewHide();
    }

    public override void ViewHide()
    {
        CurrentView = null;
    }
}