namespace Basics.Models;

public class User
{
    public int Id { get; }

    private readonly string _name = "Ruslan";

    private string _email = string.Empty;


    public string GetInfo
    {
        get => $"User: {_name}, ID: {Id}  Email: {_email}";
    }

    public void SetEmail(string email)
    {
        _email = email;
    }
}
