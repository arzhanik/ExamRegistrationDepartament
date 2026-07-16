namespace RedExamDep;

class Program
{
    public static void Main()
    {
        LicenseView licenseView = new LicenseView();

        licenseView.ChooseExamDay(new DateOnly(2026, 7, 25));

        licenseView.PrintExamDays();
    }
}
