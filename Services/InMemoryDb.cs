using Microsoft.EntityFrameworkCore;

using taskman_rest_dotnet.Models;

namespace taskman_rest_dotnet.Services;

public class InMemoryDb : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Todo> Todos { get; set; }
    public DbSet<TodoNote> TodoNotes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "TodoDb");
    }
}
