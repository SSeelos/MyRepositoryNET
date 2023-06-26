using System.Reflection;

namespace MyRootNamespace.MyClassLibraryNET;

public class MyDerivedClass : MyClass
{
    /// <summary>
    /// "new" method gets only called if not cast to base class!
    /// (<see cref="MyClass.MyNewMethod"/> || <see cref="_MyAbstractClass.MyNewMethod"/>)
    /// </summary>
    public new string MyNewMethod()
    {
        return MethodBase.GetCurrentMethod().Display();
    }
}
