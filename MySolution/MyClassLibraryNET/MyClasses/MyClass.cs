namespace MyClassLibraryNET
{
    public class MyClass : _MyAbstractClass, IMyInterfaceA, IMyInterfaceB
    {
        #region Members
        //Methods, properties, events, constructors, and fields
        //are collectively referred to as members.

        //The means by which framework functionality is exposed to the end users of a framework.

        #region Fields
        //a type should be designed so that changes to fields of that type (name or type changes)
        //can be made without breaking code other than for members of the type.
        //This implies that all fields must be private.
        private string myField = "field value";

        //excluded from this strict restriction are constant and static read-only fields,
        //because such fields, are never required to change.
        public const string myConstant = nameof(myConstant);
        //all instances of the class share static members
        public static readonly string myStaticReadonlyField = nameof(myStaticReadonlyField);

        #endregion

        #region Properties
        //attributes    (public: accessible by any code within current or external assembly)
        public string MyAttribute = nameof(MyAttribute);

        public string MyGet { get; } = nameof(MyGet);
        public string? MyGetPrivateSet { get; private set; }
        public readonly string? MyReadOnly;

        //property & backing field
        private int myFullProperty;

        public int MyFullProperty
        {
            get { return myFullProperty; }
            set { myFullProperty = value; }
        }

        //(auto-implemented) property: field with get/set block
        public string? MyAutoProperty { get; set; }

        //all instances of the class share static properties
        public static string? MyStaticProperty { get; set; }

        //init only property: can only be set at the point of object creation
        //allows for a much more flexible immutable model
        public string? MyInit { get; init; }

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

        #region Constructors (ctor)
        //empty constructor
        public MyClass()
        {

        }
        #endregion

        public void MyInterfaceA_Method()
        {
            throw new NotImplementedException();
        }

        public void MyInterfaceB_Method()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
