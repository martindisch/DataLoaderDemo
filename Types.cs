namespace DataLoaderDemo;

public class Query
{
    public IEnumerable<Book> GetBooks([Service] Database database)
    {
        return database.BooksById.Values;
    }
}

public record Book(int Id, string Title, [property: GraphQLIgnore] int AuthorId)
{
    public async Task<Author> GetAuthorAsync([Service] IAuthorsByIdDataLoader dataLoader)
    {
        return await dataLoader.LoadAsync(AuthorId);
    }
}

public record Author(int Id, string Name)
{
    public async Task<IEnumerable<Book>> GetBooksAsync([Service] IBooksByAuthorIdDataLoader dataLoader)
    {
        return await dataLoader.LoadAsync(Id);
    }
}
