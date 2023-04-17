namespace MyClassLibraryNET.Tests
{
    public class MyRecordTests
    {
        readonly MyRecord myRecord;
        public MyRecordTests()
        {
            this.myRecord = new MyRecord()
            {
                MyInitA = nameof(MyRecord.MyInitA),
                MyInitB = nameof(MyRecord.MyInitB)
            };
        }
        [Fact]
        public void MyRecordTest()
        {
            myRecord.Should().NotBeNull();
            myRecord.MyInitA.Should().Be(nameof(MyRecord.MyInitA));
        }

        [Fact]
        public void MyRecordWith()
        {
            var myWith = myRecord with { MyInitA = nameof(MyRecord.MyInitA) + "with" };
            myWith.Should().NotBeNull();
            myWith.MyInitA.Should().Be(nameof(MyRecord.MyInitA) + "with");
            myWith.MyInitB.Should().Be(nameof(MyRecord.MyInitB));
        }

        [Fact]
        public void EqualsTest()
        {
            var other = new MyRecord
            {
                MyInitA = nameof(MyRecord.MyInitA),
                MyInitB = nameof(MyRecord.MyInitB)
            };

            //in contrast to a regular reference type,
            //record types are equal if all values of the properties are equal.
            this.myRecord.Equals(other).Should().BeTrue();
            (this.myRecord == other).Should().BeTrue();
        }
    }
}
