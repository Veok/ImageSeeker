namespace ImageSeeker.Data.File;

public class FileSearchService : IFileSearchService
{
    public IEnumerable<string> SearchAndGetFilePaths(string searchRoot, IList<string> fileTypes)
    {
        var files = Directory.GetFiles(searchRoot, "*.*", SearchOption.AllDirectories)
            .Where(x => fileTypes.Any(x.Contains));
        
        return files;
    }
}