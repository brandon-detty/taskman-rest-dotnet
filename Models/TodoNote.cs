namespace taskman_rest_dotnet.Models;

public class TodoNote : BaseModel
{
    public long TodoId { get; set; }

    public Todo? Todo { get; set; }

    public User? User { get; set; }

    public DateTime Created { get; set; }

    public int? ProgressScore { get; set; }

    public short? Type { get; set; }

    public string? Memo { get; set; }

    public TodoNote(long todoId)
    {
        TodoId = todoId;

        Created = DateTime.Now;
    }
}
