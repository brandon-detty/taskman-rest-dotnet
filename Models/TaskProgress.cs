namespace taskman_rest_dotnet.Models;

public class TaskProgress : BaseModel
{
    public long TaskId { get; set; }

    public Task? Task { get; set; }

    public User? User { get; set; }

    public DateTime Created { get; set; }

    public int? ProgressScore { get; set; }

    public short? Type { get; set; }

    public string? Memo { get; set; }

    public TaskProgress(long taskId)
    {
        TaskId = taskId;

        Created = DateTime.Now;
    }
}
