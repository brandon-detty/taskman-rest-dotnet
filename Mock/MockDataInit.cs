using taskman_rest_dotnet.Models;
using taskman_rest_dotnet.Services;

namespace taskman_rest_dotnet.Mock;

static class MockDataInit
{
    public static void Run()
    {
        UserService users = UserService.Instance;
        TaskService tasks = TaskService.Instance;

        User john =
            new(firstName: "John", lastName: "Doe", email: "johndoe@gmail.com", username: "johnd");
        users.Add(john);
        tasks.Add(
            new Models.Task(
                title: "John's Project",
                description: "Learn to boil water",
                userId: john.Id
            )
        );
        User jane =
            new(firstName: "Jane", lastName: "Doe", email: "janedoe@gmail.com", username: "janed");
        users.Add(jane);
        tasks.Add(
            new Models.Task(
                title: "Jane's Project",
                description: "Conquer the world",
                userId: jane.Id
            )
        );
    }
}
