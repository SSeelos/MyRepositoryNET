namespace MyRootNamespace.MyClassLibraryNET
{
    public class MyGenericClass<T>
    {
        public T MyValue { get; set; }
        public MyGenericClass(T value)
        {
            MyValue = value;
        }
    }
}
