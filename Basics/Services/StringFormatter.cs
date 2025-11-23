namespace Basics_0.Services;

public class StringFormatter
{
    private string _prefix;

    public StringFormatter()
    {
        _prefix = "DEFAULT";
    }

    public string FormatName(string firstName, string lastName)
    {
        var fullName = $"{firstName} {lastName}";
        return $"{_prefix}: {fullName}";
    }

    public void SetPrefix(string prefix)
    {
        _prefix = prefix;
    }

    public string CreateEmail(string userName, string domain)
    {
        var email = $"{userName}@{domain}";
        return email;
    }

    public string RepeatString(string input, int count)
    {
        string result = "";
        for (int i = 0; i < count; i++)
        {
            result += input;
        }
        return result;
    }
}