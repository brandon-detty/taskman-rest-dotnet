using taskman_rest_dotnet.Models;
using taskman_rest_dotnet.Services;

namespace taskman_rest_dotnet.Mock;

static class MockDataInit
{
    public static void Run(IServiceProvider services)
    {
        var users = services.GetService<ICachedService<User>>();
        var todos = services.GetService<ICachedService<Todo>>();

        User john =
            new(firstName: "John", lastName: "Doe", email: "johndoe@gmail.com", username: "johnd");
        users.Add(john);
        todos.Add(
            new Todo(title: "John's Project", description: "Learn to boil water", userId: john.Id)
        );
        User jane =
            new(firstName: "Jane", lastName: "Doe", email: "janedoe@gmail.com", username: "janed");
        users.Add(jane);
        todos.Add(
            new Todo(title: "Jane's Project", description: "Conquer the world", userId: jane.Id)
        );
    }
}
