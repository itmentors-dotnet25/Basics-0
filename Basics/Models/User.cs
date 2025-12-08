namespace Basics_0.Models;

public class User
{
    public int id;
    public string name;
    private string _email;

    public User()
    {
        id = 0;
        name = "Unknown";
        _email = "";
    }

    public string GetInfo()
    {
        return $"User: {name}, ID: {id}";
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
