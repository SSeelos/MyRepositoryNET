namespace SystemExtensions
{
    public static class EnvironmentExt
    {
        public static string GetPath(this Environment.SpecialFolder specialFolder)
            => Environment.GetFolderPath(specialFolder);
    }
}
