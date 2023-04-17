namespace MyClassLibraryNET
{
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

        public static void MyExtensionMethod(this MyClass subject)
        {
            throw new NotImplementedException();
        }
    }
}
