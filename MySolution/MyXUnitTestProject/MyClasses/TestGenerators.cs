using MyClassLibraryNetStandard2_0.SourceGenerators;

namespace MyXUnitTestProject
{
    public class TestGenerators
    {
        [Fact()]
        public void SourceGeneratedClassTest()
        {
            var myGeneratedClass = new MyGeneratedClass();

            Action action = () => myGeneratedClass.MyGeneratedMethod();
            action.Should().NotThrow();
        }
        [Fact()]
        public void PartialGeneratedClassTest()
        {
            var myGeneratedClass = new MyPartialGeneratedClass();

            Action action = () => myGeneratedClass.RunPartialMethod();
            action.Should().NotThrow();
        }
    }
}
