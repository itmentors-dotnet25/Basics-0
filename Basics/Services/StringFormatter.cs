using System.Text;

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

    public static string CreateEmail(string userName, string domain)
    {
        var email = $"{userName}@{domain}";
        return email;
    }

    public static string RepeatString(string input, int count)
    {
        var result = new StringBuilder(input.Length * count);
        for (int i = 0; i < count; i++)
        {
            result.Append(input);
        }
        return result.ToString();
    }
}