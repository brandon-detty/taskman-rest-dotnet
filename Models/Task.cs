namespace taskman_rest_dotnet.Models;

public class Task : BaseModel
{
    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime Created { get; set; }

    public DateTime? Due { get; set; }

    public int ProgressScore { get; set; }

    public int CompletedScore { get; set; }

    public long UserId { get; set; }

    public Task(
        string title,
        string description,
        long userId,
        DateTime? due = null,
        int progressScore = 0,
        int completedScore = 100
    )
    {
        Title = title;
        Description = description;
        ProgressScore = progressScore;
        CompletedScore = completedScore;
        UserId = userId;

        Due = due;

        Created = DateTime.Now;
    }
}
