var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddConsole();
builder.Services
    .AddSingleton<Database>()
    .AddGraphQLServer()
    .AddTypes(typeof(Query));

var app = builder.Build();
app.MapGraphQL();

app.Run();
