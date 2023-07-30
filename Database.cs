public class Database
{
    public Dictionary<int, BookModel> BooksById = new() {
        { 1, new(1, "First Book", 1) },
        { 2, new(2, "Second Book", 2) },
        { 3, new(3, "Third Book", 1) },
        { 4, new(4, "Fourth Book", 1) },
        { 5, new(5, "Fifth Book", 3) },
        { 6, new(6, "Sixth Book", 3) },
        { 7, new(7, "Seventh Book", 1) },
    };

    public Dictionary<int, AuthorModel> AuthorsById = new() {
        { 1, new(1, "First Author") },
        { 2, new(2, "Second Author") },
        { 3, new(3, "Third Author") },
    };
}

public record BookModel(int Id, string Title, int authorId);

public record AuthorModel(int Id, string Name);
