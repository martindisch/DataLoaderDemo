namespace DataLoaderDemo;

public class Database
{
    public Dictionary<int, Book> BooksById = new() {
        { 1, new(1, "First Book", 1) },
        { 2, new(2, "Second Book", 2) },
        { 3, new(3, "Third Book", 1) },
        { 4, new(4, "Fourth Book", 1) },
        { 5, new(5, "Fifth Book", 3) },
        { 6, new(6, "Sixth Book", 3) },
        { 7, new(7, "Seventh Book", 1) },
    };

    public Dictionary<int, Author> AuthorsById = new() {
        { 1, new(1, "First Author") },
        { 2, new(2, "Second Author") },
        { 3, new(3, "Third Author") },
    };
}
