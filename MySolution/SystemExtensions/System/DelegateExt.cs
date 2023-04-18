using SystemExtensions.CompilerServices;

namespace SystemExtensions
{
    public static class DelegateExt
    {
        public static bool IsAnonymous(this Delegate deleg)
            => deleg.Method.IsAnonymous();
        public static string DisplayMethod(this Delegate deleg)
            => deleg.Method.Display();
    }
}
