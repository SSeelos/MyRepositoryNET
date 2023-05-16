namespace MyRootNamespace.MyClassLibraryNET
{
    /// <summary>
    ///An immutable type is a type of which its properties can only be set at initialization.

    ///Note that private set only provides a restricted encapsulation
    ///of change to the property from within the same class,
    ///and thus isn't truly immutable
    /// </summary>
    public class MyImmutableClass
    {
        private readonly string _myImmutableProperty;
        public string MyImmutableProperty
            => _myImmutableProperty;

        public MyImmutableClass(string prop)
        {
            _myImmutableProperty = prop;
        }

        public string MyGetOnlyAutoProperty { get; }

        //in C#6 and later,
        //getter-only auto properties have now been implemented,
        //which allows for immutable auto-properties
        //without the need for the additional explicit private readonly backing field
        public MyImmutableClass(string prop, string autoprop)
        {
            _myImmutableProperty = prop;

            // The compiler understands this and initializes the backing field
            MyGetOnlyAutoProperty = autoprop;
        }
    }
}
