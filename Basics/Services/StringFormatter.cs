using System.Text;

namespace Basics_0.Services;

public class StringFormatter
{
    private string _prefix = "DEFAULT";

    public string FormatName(string firstName, string lastName)
    {
        return $"{_prefix}: {firstName} {lastName}";
    }

    public void SetPrefix(string prefix)
    {
        _prefix = prefix;
    }

    public static string CreateEmail(string userName, string domain)
    {
        return $"{userName}@{domain}";
    }

    public static string RepeatString(string input, int count)
    {
        var builder = new StringBuilder(input.Length * count);

        for (int i = 0; i < count; i++)
        {
            builder.Append(input);
        }

        return builder.ToString();
    }
}
