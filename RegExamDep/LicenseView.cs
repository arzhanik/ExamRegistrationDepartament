namespace RedExamDep;

sealed class LicenseView : View
{
    public Dictionary<DateOnly, bool> ExamDays { get; set; }

    public enum DriverPoints
    {
        A,
        B,
        C,
        D,
        E
    }

    
}