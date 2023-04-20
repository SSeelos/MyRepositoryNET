namespace MyClassLibraryNetStandard2_1
{
    public class MyClass
    {
        public MyClass()
        {
            //net Standard 2.1 can reference net Standard 2.0
            var class20 = new MyClassLibraryNetStandard2_0.MyClass();
        }
    }
}
