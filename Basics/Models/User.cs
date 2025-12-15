namespace Basics0.Models;

public class User
{
    public int Id { get; set; }

    private const string Name = "Ruslan";

    private string _email = string.Empty;


    public string GetInfo
    {
        get => $"User: {Name}, ID: {Id}  Email: {_email}";
    }

    public void SetEmail(string email)
    {
        _email = email;
    }
}
