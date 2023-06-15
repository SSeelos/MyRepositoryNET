namespace MyLibraryTargetframeworks
{
    public static class FrameworkTest
    {
        public static string GetTargetFramework()
        {
#if NETSTANDARD2_1
            return "NETSTANDARD2_1";
#endif

#if NET48_OR_GREATER
            return "NET48_OR_GREATER";
#endif
        }
    }
}
