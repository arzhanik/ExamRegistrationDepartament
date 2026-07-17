namespace RedExamDep;

public interface ICalendarService
{
    public bool ChooseExamDay(DateOnly day, ulong userSocialCardNumber);
    public void PrintExamDays();
}