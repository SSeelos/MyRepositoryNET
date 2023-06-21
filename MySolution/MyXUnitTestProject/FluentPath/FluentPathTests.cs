//todo

//using FluentAssertions.Execution;
//using Path = Fluent.IO.Path;

//namespace MyXUnitTestProject
//{
//    public class FluentPathTests
//    {

//        [Fact]
//        public void Function()
//        {
//            string path = @"C:\Users\sse\source\repos\MyWixInstallerProject\TestProject\FluentPath\FluentPathTests.cs";
//            var p = Path.Get(path);

//            using (new AssertionScope())
//            {
//                p.Exists.Should().BeTrue();
//                p.GetDirectoryInfo().Exists
//                    .Should().BeTrue();
//                p.GetFileInfo().Exists
//                    .Should().BeTrue();

//                p.IsRooted.Should().BeTrue();
//                p.IsDirectory.Should().Be(false);
//                p.DirectoryName
//                    .Should().Be(@"C:\Users\sse\source\repos\MyWixInstallerProject\TestProject\FluentPath");
//                p.FileName
//                    .Should().Be("FluentPathTests.cs");
//                p.FileNameWithoutExtension
//                    .Should().Be("FluentPathTests");
//                p.FullPath
//                    .Should().Be(path);
//                p.Extension
//                    .Should().Be(".cs");

//            }
//        }

//    }
//}
