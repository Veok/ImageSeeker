namespace ImageSeeker.Data.DirectoryTreeDialog;

public class DirectoryTreeDialogService : IDirectoryTreeDialogService
{
    public IEnumerable<string> GetMyDocuments()
    {
        return Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
            .Where(entry =>
            {
                var name = Path.GetFileName(entry);
                return !name.StartsWith(".");
            });
    }
}