

namespace MyClassLibraryNetFramework
{
    public class MyClass
    {
        public MyClass()
        {
            //net Framework can only reference net Standard 2.0
            var class20 = new MyClassLibraryNetStandard2_0.MyClass();
        }
    }
}
