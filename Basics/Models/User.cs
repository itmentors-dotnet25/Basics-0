namespace Basics_0.Models;

public class User
{
    private readonly int _id;
    private readonly string _Name;
    private string _email;

    public User()
    {
        _id = 0;
        _Name = "Unknown";
        _email = "";
    }

    public string GetInfo()
    {
        return $"User: {_Name}, ID: {_id}, email: {_email}";
    }

    public void SetEmail(string email)
    {
        _email = email;
    }
}