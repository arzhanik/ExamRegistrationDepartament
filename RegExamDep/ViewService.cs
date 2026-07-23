using System.ComponentModel.Design;

namespace RedExamDep;

public abstract class ViewService<T>
{
    public abstract void ViewInitialize(T content);
    public abstract void ViewShow();
    public abstract void ViewHide();
}