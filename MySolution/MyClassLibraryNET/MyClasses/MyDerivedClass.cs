namespace MyRootNamespace.MyClassLibraryNET;

public class MyDerivedClass : MyClass
{
    /// <summary>
    /// "new" method gets only called if not cast to base class!
    /// (<see cref="MyClass"/> || <see cref="_MyAbstractClass"/>)
    /// </summary>
    public new void MyNewMethod()
    {
        base.MyNewMethod();
    }
}
