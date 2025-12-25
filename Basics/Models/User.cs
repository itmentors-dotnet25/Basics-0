namespace Basics_0.Models;

public class User
{
    private int Id { get; }
    private readonly string _name;
    private string _email;

    public User()
    {
        Id = 0;
        _name = "Unknown";
        _email = "";
    }

    public string GetInfo()
    {
        return $"User: {_name}, ID: {Id} Email: {_email}";
    }

    public void SetEmail(string email)
    {
        _email = email;
    }
}