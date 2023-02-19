namespace ImageSeeker.Data.File;

public class FileMoveService : IFileMoveService
{
    public async IAsyncEnumerable<string> MoveFilesToNewDestinationAsync(string destinationPath, IEnumerable<string> filePaths)
    {
        foreach (var filePath in filePaths)
        {
            var fileName = filePath.Split(Path.DirectorySeparatorChar).Last();
            await Task.Run(() => Directory.Move(filePath, Path.Combine(destinationPath, fileName)));
            yield return filePath;
        }
    }
}