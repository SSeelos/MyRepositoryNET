using System.Reflection;

namespace MyRootNamespace.MyClassLibraryNET;

/// <summary>
/// base class
/// </summary>
public abstract class _MyAbstractClass : IMyInterfaceC
{
    public static string _myStaticProperty;

    //only accessible from this class
    private string? _myField;
    //only accessible from derived classes
    protected string? _myProtectedField;

    public abstract string MyAbstractProperty { get; set; }

    public _MyAbstractClass()
    {

    }
    public _MyAbstractClass(string fieldValue)
    {
        this._myField = fieldValue;
    }

    public void MyMethodFromBase()
    {
        //...
    }
    public void MyInterfaceC_Method()
    {
        //...
    }

    /// <summary>
    /// derived classes MUST override abstract methods
    /// </summary>
    protected abstract void MyProtectedAbstractMethod();
    /// <summary>
    /// derived classes MUST override abstract methods
    /// </summary>
    public abstract void MyAbstractMethod();

    /// <summary>
    /// derived classes CAN override virtual method (default implementation)
    /// </summary>
    protected virtual void MyProtectedVirtualMethod()
    {
        //...
    }

    /// <summary>
    /// derived classes CAN override virtual method (default implementation)
    /// </summary>
    public virtual void MyVirtualMethod()
    {
        //...
    }


    /// <summary>
    /// use the new keyword in a derived class to test the behaviour
    /// <br>(<see cref="MyClass.MyNewMethod"/> || <see cref="MyDerivedClass.MyNewMethod"/>)</br>
    /// <br>any derived class cast to this abstract class will call this method rather than the "new" method of the derived class!</br>
    /// </summary>
    public string MyNewMethod()
    {
        return MethodBase.GetCurrentMethod().Display();
    }
}
