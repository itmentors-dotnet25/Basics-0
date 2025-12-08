namespace Basics_0.Models;

public class User(int _id, string _name = "Unknown", string? _email= "")
{
    public string GetInfo()
    {
        return $"User: {_name}, ID: {_id}";
    }

    public void SetEmail(string email)
    {
        _email = email;
    }
}