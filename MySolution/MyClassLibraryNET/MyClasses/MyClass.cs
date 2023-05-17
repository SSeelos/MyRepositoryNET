using System.Reflection;

namespace MyRootNamespace.MyClassLibraryNET;

/// <summary>
/// reference type
/// </summary>
public class MyClass : _MyAbstractClass, IMyInterfaceA, IMyInterfaceB
{
    #region Members
    //Methods, properties, events, constructors, and fields
    //are collectively referred to as members.

    //The means by which framework functionality is exposed to the end users of a framework.

    #region Fields
    /// <summary>
    /// a type should be designed so that changes to fields of that type (name or type changes)
    /// can be made without breaking code other than for members of the type.
    /// This implies that all fields must be private.
    /// </summary>
    private string myField = "field value";

    //excluded from this strict restriction are constant and static read-only fields,
    //because such fields, are never required to change.
    /// <summary>
    /// compile-time const (static by default)
    /// </summary>
    public const string myConstant = nameof(myConstant);
    /// <summary>
    /// all instances of the class share static members
    /// </summary>
    public static readonly string myStaticReadonlyField = nameof(myStaticReadonlyField);

    #endregion

    #region Properties
    //attributes    (public: accessible by any code within current or external assembly)
    public string MyAttribute = nameof(MyAttribute);

    public string MyGet { get; } = nameof(MyGet);
    public string? MyGetPrivateSet { get; private set; }
    public readonly string? MyReadOnly;

    //property & backing field

    /// <summary>
    /// backing field for <see cref="MyFullProperty"/>
    /// </summary>
    private int myFullProperty;
    /// <summary>
    /// property with (explicit) backing field <see cref="myFullProperty"/>
    /// </summary>

    public int MyFullProperty
    {
        get { return myFullProperty; }
        set { myFullProperty = value; }
    }

    /// <summary>
    /// (auto-implemented) property: field with get/set block
    /// </summary>
    public string? MyAutoProperty { get; set; }

    /// <summary>
    /// all instances of the class share static properties
    /// </summary>
    public static string? MyStaticProperty { get; set; }

    /// <summary>
    /// init only property: can only be set at the point of object creation (readonly)
    /// allows for a much more flexible immutable model
    /// </summary>
    public string? MyInitNullable { get; init; }
    /// </summary>
    public string MyInit { get; init; }

    public static MyClass MyStaticInstance = new MyClass();

    #region Advanced Property

    public double Min;
    public double Max;

    //backing field
    private double _myValue;
    public double MyClampedValue
    {
        get => _myValue;
        set
        {
            _myValue = Math.Clamp(value, Min, Max);
            OnValueChanged?.Invoke(_myValue);
        }
    }
    public event Action<double>? OnValueChanged;

    #endregion

    #endregion

    #region Events
    public static event Action? MyStaticEventAction;
    /// <summary>
    /// Method to invoke <see cref="MyStaticEventAction"/>
    /// </summary>
    public static void InvokeStaticAction() => MyStaticEventAction?.Invoke();
    public static event Func<string>? MyStaticEventFunc;
    /// <summary>
    /// Method to invoke <see cref="MyStaticEventFunc"/>
    /// </summary>
    public static string? InvokeStaticFunc() => MyStaticEventFunc?.Invoke();

    #endregion

    #region Constructors (ctor)
    /// <summary>
    /// empty constructor
    /// </summary>
    public MyClass()
    {
    }
    public MyClass(string readOnlyValue)
    {
        //readonly can only be set in ctor (or init)
        this.MyReadOnly = readOnlyValue;
    }
    private MyClass(string readOnlyValue, string? nullableValue)
    {
        //readonly can only be set in ctor (or init)
        this.MyReadOnly = readOnlyValue;
        this.MyInitNullable = nullableValue;
    }
    /// <summary>
    /// Factory method to create new instance of <see cref="MyClass"/> using private ctor
    /// </summary>
    public static MyClass New(string init) => new("new", "nullable") { MyInit = init };
    #endregion

    #region Methods

    public string MyMethod()
    {
        var memberName = MyStaticClass.GetCallerMemberName();
        return MethodBase.GetCurrentMethod().Name;
    }
    public static void MyStaticMethod()
    {
        throw new NotImplementedException();
    }


    public void MyInterfaceA_Method()
    {
        throw new NotImplementedException();
    }

    public void MyInterfaceB_Method()
    {
        throw new NotImplementedException();
    }

    protected override void MyProtectedAbstractMethod()
    {
        throw new NotImplementedException();
    }

    public override void MyAbstractMethod()
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// "new" method gets only called if not cast to base class!
    /// (<see cref="_MyAbstractClass"/>)
    /// </summary>
    public new string MyNewMethod()
    {
        throw new NotImplementedException();
    }

    #endregion

    #endregion
}
