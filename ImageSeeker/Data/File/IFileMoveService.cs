namespace ImageSeeker.Data.File;

public interface IFileMoveService
{
    Task MoveFilesToNewDestination(string destinationPath, IEnumerable<string> filePaths);
}