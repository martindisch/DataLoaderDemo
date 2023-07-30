namespace DataLoaderDemo;

public static class DataLoaders
{
    [DataLoader]
    public static async Task<IReadOnlyDictionary<int, Author>> GetAuthorsByIdAsync(IReadOnlyList<int> authorIds, [Service] Database database, [Service] ILogger<Author> logger)
    {
        logger.LogInformation("Fetching authors with IDs {AuthorIds}", authorIds);
        await Task.CompletedTask;
        return database.AuthorsById
            .Where(kvp => authorIds.Contains(kvp.Key))
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }

    [DataLoader]
    public static async Task<ILookup<int, Book>> GetBooksByAuthorIdAsync(IReadOnlyList<int> authorIds, [Service] Database database, [Service] ILogger<Book> logger)
    {
        logger.LogInformation("Fetching books for authors with IDs {AuthorIds}", authorIds);
        await Task.CompletedTask;
        return database.BooksById.Values
            .Where(kvp => authorIds.Contains(kvp.AuthorId))
            .ToLookup(kvp => kvp.AuthorId);
    }
}
