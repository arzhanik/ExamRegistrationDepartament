namespace RedExamDep;

class Program
{
    public static void Main()
    {
        ReserveInfo reserveInfo = new ReserveInfo();

        reserveInfo.ChooseExamDay(new DateOnly(2026, 7, 25), (ulong)45655456);
        reserveInfo.ChooseExamDay(new DateOnly(2026, 7, 19), (ulong)45655456);
        reserveInfo.ChooseExamDay(new DateOnly(2026, 7, 27), (ulong)45655456);
        reserveInfo.ChooseExamDay(new DateOnly(2026, 7, 22), (ulong)45655456);

        reserveInfo.PrintExamDays();
    }
}
