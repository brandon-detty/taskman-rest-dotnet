using taskman_rest_dotnet.Mock;
using taskman_rest_dotnet.Models;
using taskman_rest_dotnet.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<ICachedService<User>, CachedService<User>>();
builder.Services.AddSingleton<ICachedService<Todo>, CachedService<Todo>>();
builder.Services.AddSingleton<ICachedService<TodoNote>, CachedService<TodoNote>>();

IMvcBuilder mvcBuilder = builder.Services.AddControllers();

if (builder.Environment.IsDevelopment())
{
    mvcBuilder.AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.WriteIndented = true;
    });
}

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    MockDataInit.Run(app.Services);
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
