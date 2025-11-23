namespace Basics_0.Models;

public class User
{
    public int id;
    public string Name;
    private string _email;

    public User()
    {
        id = 0;
        Name = "Unknown";
        _email = "";
    }

    public string GetInfo()
    {
        return $"User: {Name}, ID: {id}";
    }

    public void SetEmail(string email)
    {
        _email = email;
    }
}