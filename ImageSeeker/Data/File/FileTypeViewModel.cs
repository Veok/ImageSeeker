using System.Diagnostics.CodeAnalysis;

namespace ImageSeeker.Data.File;

[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class FileTypeViewModel
{
    public int Id { get; }
    public string FileType { get; }

    public FileTypeViewModel(int id, string fileType)
    {
        Id = id;
        FileType = fileType;
    }
}