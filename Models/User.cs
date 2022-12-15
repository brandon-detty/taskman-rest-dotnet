namespace taskman_rest_dotnet.Models;

public class User : BaseModel
{
    public string Username { get; set; }

    public string Email { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string? Salt { get; set; }

    public string? PasswordHash { get; set; }

    public DateTime Created { get; set; }

    public User(string username, string email, string firstName, string lastName)
    {
        Username = username;
        Email = email;
        FirstName = firstName;
        LastName = lastName;

        Created = DateTime.Now;
    }
}
