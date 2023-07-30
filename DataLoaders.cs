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
}
