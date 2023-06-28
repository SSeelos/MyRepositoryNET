using Microsoft.CodeAnalysis;

namespace MyClassLibraryNetStandard2_0
{
    [Generator]
    public class MyIncrementalGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            //execution via a series of transformations

        }
    }
}
