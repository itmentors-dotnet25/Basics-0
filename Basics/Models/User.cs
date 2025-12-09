namespace Basics_0.Models;

public class User
{
    private readonly int _id;
    private readonly string _name;
    private string _email;

    public User()
    {
        _id = 0;
        _name = "Unknown";
        _email = "";
    }

    public string GetInfo()
    {
        return $"User: {_name}, ID: {_id}";
    }

    public void SetEmail(string email)
    {
        _email = email;
    }
    public string GetEmail()
    {
        return _email;
    }
}
