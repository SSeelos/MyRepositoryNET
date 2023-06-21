using MyClassLibraryNetStandard2_0.SourceGenerators;

namespace MyRootNamespace.MyClassLibraryNET
{
    public class MySourceGeneratorUser
    {
        public static void UseGeneratedClass()
        {
            var myGeneratedClass = new MyGeneratedClass();
            myGeneratedClass.MyGeneratedMethod();

            var partialC = new MyPartialGeneratedClass();
        }
    }
}
