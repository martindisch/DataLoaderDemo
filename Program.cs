using DataLoaderDemo;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddConsole();
builder.Services
    .AddSingleton<Database>()
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddDataLoaderDemoTypes();

var app = builder.Build();
app.MapGraphQL();

app.Run();
