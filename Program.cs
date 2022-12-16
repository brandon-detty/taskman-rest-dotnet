var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

taskman_rest_dotnet.Mock.MockDataInit.Run();

app.Run();
