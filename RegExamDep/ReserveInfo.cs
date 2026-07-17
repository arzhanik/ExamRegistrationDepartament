namespace RedExamDep;

public class ReserveInfo : ICalendarService
{
    public Dictionary<DateOnly, ulong> ReservedUserAndDayInfo { get; set; }

    public ReserveInfo()
    {
        ReservedUserAndDayInfo = new Dictionary<DateOnly, ulong>(365);
        DateOnly now = DateOnly.FromDateTime(DateTime.Today);
        for (int dayCounter = 0; dayCounter < 365; dayCounter++)
        {
            ReservedUserAndDayInfo[now.AddDays(dayCounter)] = 0;
        }
    }

    public bool ChooseExamDay(DateOnly day, ulong userSocialCardNumber)
    {
        if (!ReservedUserAndDayInfo.TryGetValue(day, out ulong occupied))
        {
            return false;
        }

        if (occupied != 0)
        {
            return false;
        }
        ReservedUserAndDayInfo[day] = userSocialCardNumber;
        return true;
    }

    public bool ChooseDriverPoints(string points)
    {
        return true;
    }
    
    public void PrintExamDays()
    {
        DateOnly start = DateOnly.FromDateTime(DateTime.Today);

        int currentYear = start.Year;
        int currentMonth = start.Month;

        DateOnly end = start.AddDays(365);

        while (new DateOnly(currentYear, currentMonth, 1) < end)
        {
            Console.WriteLine($"\n{new DateTime(currentYear, currentMonth, 1):MMMM yyyy}");
            Console.WriteLine("Mo Tu We Th Fr Sa Su");

            DateOnly firstDay = new DateOnly(currentYear, currentMonth, 1);
            int startDay = ((int)firstDay.DayOfWeek + 6) % 7;

            for (int i = 0; i < startDay; i++)
            {
                Console.Write("    ");
            }

            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);

            for (int day = 1; day <= daysInMonth; day++)
            {
                DateOnly currentDate = new DateOnly(currentYear, currentMonth, day);

                if (currentDate < start || currentDate >= end)
                {
                    Console.Write("    ");
                }
                else if (ReservedUserAndDayInfo.TryGetValue(currentDate, out ulong occupied) && occupied != 0)
                {
                    Console.Write("--  ");
                }
                else
                {
                    Console.Write($"{day,2}  ");
                }

                if ((startDay + day) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            currentMonth++;
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear++;
            }
        }
    }
}