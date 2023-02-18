namespace ImageSeeker.Data.File;

public interface IFileSearchService
{
   IEnumerable<string> SearchAndGetFilePaths(string searchRoot, IList<string> fileTypes);
}