using System.Reflection;
using System.Runtime.CompilerServices;

namespace MyRootNamespace.MyClassLibraryNET;

public static class MyStaticClass
{
    static readonly string? myStaticField = nameof(myStaticField);
    public static string? MyProperty { get; set; }
    public const string MyConstant = nameof(MyConstant);
    public static readonly string MyReadOnly = nameof(MyReadOnly);


    public static string MyMethod()
    {
        return MethodBase.GetCurrentMethod().Display();
    }

    /// <summary>
    /// extension method for <see cref="MyClass"/>
    /// </summary>
    public static string MyExtensionMethod(this MyClass subject)
    {
        return MethodBase.GetCurrentMethod().Display();
    }
    public static string MyExtensionMethod(this _MyAbstractClass subject)
    {
        return MethodBase.GetCurrentMethod().Display();
    }
    /// <summary>
    /// will never be called because class already defines this signature
    /// <see cref="MyClass.MyMethod"/>
    /// </summary>
    public static string MyMethod(this MyClass subject)
    {
        return MethodBase.GetCurrentMethod().Display();
    }
    public static string GetCallerMemberName([CallerMemberName] string callerMemberName = "")
        => callerMemberName;
}
