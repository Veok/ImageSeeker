namespace ImageSeeker.Data.File;

public static class FileTypeData
{
    public static IList<FileTypeViewModel> Get()
    {
        return new List<FileTypeViewModel>
        {
            new(1, FileTypeConstants.Png),
            new(2, FileTypeConstants.Jpeg),
            new(3, FileTypeConstants.Giff),
            new(4, FileTypeConstants.Svg)
        };
    }
}