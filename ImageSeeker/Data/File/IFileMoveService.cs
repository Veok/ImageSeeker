namespace ImageSeeker.Data.File;

public interface IFileMoveService
{
    IAsyncEnumerable<string> MoveFilesToNewDestinationAsync(string destinationPath, IEnumerable<string> filePaths);
}