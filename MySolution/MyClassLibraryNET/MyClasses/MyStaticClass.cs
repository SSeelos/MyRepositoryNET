using System.Runtime.CompilerServices;

namespace MyRootNamespace.MyClassLibraryNET;

public static class MyStaticClass
{
    static readonly string? myStaticField = nameof(myStaticField);
    public static string? MyProperty { get; set; }
    public const string MyConstant = nameof(MyConstant);
    public static readonly string MyReadOnly = nameof(MyReadOnly);


    public static void MyMethod()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// extension method for <see cref="MyClass"/>
    /// </summary>
    public static void MyExtensionMethod(this MyClass subject)
    {
        throw new NotImplementedException();
    }
    public static void MyExtensionMethod(this _MyAbstractClass subject)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// will never be called because class already defines this signature
    /// <see cref="MyClass.MyMethod"/>
    /// </summary>
    public static void MyMethod(this MyClass subject)
    {
        throw new NotImplementedException();
    }
    public static string GetCallerMemberName([CallerMemberName] string callerMemberName = "")
        => callerMemberName;
}
