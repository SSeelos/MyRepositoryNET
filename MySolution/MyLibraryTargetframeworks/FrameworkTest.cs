namespace MyLibraryTargetframeworks
{
    public static class FrameworkTest
    {
        public static string GetTargetFramework()
        {
#if NETSTANDARD2_0
            return "NETSTANDARD2_0";
#endif
#if NETSTANDARD2_1
            return "NETSTANDARD2_1";
#endif

#if NET48_OR_GREATER
            return "NET48_OR_GREATER";
#endif
#if NET5_0_OR_GREATER
            return "NET5_0_OR_GREATER";
#endif
        }
    }
}
