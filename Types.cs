using HotChocolate;

public class Query
{
    public IEnumerable<Book> GetBooks([Service] Database database)
    {
        return database.BooksById.Values;
    }
}

public record Book(int Id, string Title, [property: GraphQLIgnore] int AuthorId)
{
    public Author GetAuthor([Service] Database database, [Service] ILogger<Book> logger)
    {
        logger.LogInformation("Fetching author with ID {AuthorId}", AuthorId);
        return database.AuthorsById[AuthorId];
    }
}

public record Author(int Id, string Name);
