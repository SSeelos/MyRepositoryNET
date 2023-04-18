using System.Reflection;

namespace SystemExtensions.Reflection
{
    public static class MethodBaseExt
    {
        public static string Display(this MethodBase method)
            => $"{method.DeclaringType?.Display()}.{method.Name}";
    }
}
