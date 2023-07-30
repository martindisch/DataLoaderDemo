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
    public Author GetAuthor([Service] Database database)
    {
        return database.AuthorsById[AuthorId];
    }
}

public record Author(int Id, string Name);
