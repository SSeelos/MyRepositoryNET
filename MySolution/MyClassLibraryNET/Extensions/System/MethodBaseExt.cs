using System.Reflection;

namespace MyRootNamespace.MyClassLibraryNET
{
    public static class MethodBaseExt
    {
        /// <summary>
        /// "MyClass.MyMethod()"
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static string Display(this MethodBase method)
            => $"{method.DeclaringType?.Name}.{method.Name}()";

    }
}
