namespace RedExamDep;

public class User
{
    public uint UserSocialNumber { get; set; }
    public DateOnly ExamDay { get; set; }
    public string DriverPoints { get; set; }

    public User(uint userSocialNumber)
    {
        UserSocialNumber = userSocialNumber;
    }
}