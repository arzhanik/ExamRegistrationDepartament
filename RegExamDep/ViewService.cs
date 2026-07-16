using System.ComponentModel.Design;

namespace RedExamDep;

public abstract class ViewService<ViewType>
{
    public abstract void ViewInitialize();
    public abstract void ViewShow();
    public abstract void ViewHide();
}