using HotChocolate;

public class Query
{
    public IEnumerable<Book> GetBooks([Service] Database database)
    {
        return database.BooksById.Values
            .Select(bookModel => new Book(bookModel.Id, bookModel.Title));
    }
}

public record Book(int Id, string Title)
{
    public Author GetAuthor([Service] Database database)
    {
        var authorId = database.BooksById[Id].authorId;
        var author = database.AuthorsById[authorId];

        return new(author.Id, author.Name);
    }
}

public record Author(int Id, string Name);
