namespace SystemExtensions;

public static class DirectoryExt
{
    public static DirectoryInfo GetCurrent()
        => new DirectoryInfo(Directory.GetCurrentDirectory());
    /// <summary>
    /// search upwards for a directory containing a file matching the pattern (*.sln, ..)
    /// </summary>
    public static DirectoryInfo GetElder(string pattern)
    {
        DirectoryInfo? directory = GetCurrent();
        while (directory != null && !directory.GetFiles(pattern).Any())
        {
            directory = directory.Parent;
        }

        return directory;
    }
    /// <summary>
    /// search upwards for a directory containing a file
    /// </summary>
    public static DirectoryInfo GetElder(this DirectoryInfo directory, Func<FileInfo, bool> filePredicate)
    {
        var file = directory.GetFilesUpwards(filePredicate).FirstOrDefault();

        return file?.Directory;
    }
    public static IEnumerable<FileInfo> GetFilesUpwards(this DirectoryInfo directoryInfo, Func<FileInfo, bool> filePredicate)
    {
        IEnumerable<FileInfo> files = Enumerable.Empty<FileInfo>();
        while (directoryInfo.Parent != null && !files.Any())
        {
            directoryInfo = directoryInfo.Parent;
            files = directoryInfo.GetFiles()
                .Where(filePredicate);
        }
        return files;
    }
}
