namespace MyRootNamespace.MyClassLibraryNET
{
    public class MyPrivateCtorClass
    {
        private MyPrivateCtorClass()
        {

        }
        /// <summary>
        /// classes with private ctor can be instantiated by static factory method
        /// </summary>
        public static MyPrivateCtorClass Create()
        {
            return new MyPrivateCtorClass();
        }
    }
}
