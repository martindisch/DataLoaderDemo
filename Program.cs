var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddSingleton<Database>()
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();
app.MapGraphQL();

app.Run();
