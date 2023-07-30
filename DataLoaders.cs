namespace DataLoaderDemo;

public static class DataLoaders
{
    [DataLoader]
    public static async Task<IReadOnlyDictionary<int, Author>> GetAuthorsByIdAsync(IReadOnlyList<int> authorIds, [Service] Database database)
    {
        await Task.CompletedTask;
        return database.AuthorsById
            .Where(kvp => authorIds.Contains(kvp.Key))
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }
}
