namespace Basics_0.Models;

public class User
{
    private const int Id = 0;
    private const string Name = "Unknown";
    private string _email = string.Empty;

    public string GetInfo()
    {
        return $"User: {Name}, ID: {Id},  Email: {_email}";
    }

    public void SetEmail(string email)
    {
        _email = email;
    }
}
