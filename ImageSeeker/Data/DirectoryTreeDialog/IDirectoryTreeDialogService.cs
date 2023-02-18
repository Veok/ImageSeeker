namespace ImageSeeker.Data.DirectoryTreeDialog;

public interface IDirectoryTreeDialogService
{
    IEnumerable<string> GetMyDocuments();
}