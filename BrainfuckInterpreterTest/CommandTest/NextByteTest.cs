using BrainfuckInterpreter;

namespace BrainfuckInterpreterTest.CommandTest
{
    [TestClass]
    public class NextByteTest
    {
        private DataArray dataArray = new DataArray();

        [TestMethod]
        public void CallNextNTimes_EqualsN()
        {
            int expected = Random.Shared.Next(30000);
            for (int index = 0; index < expected; ++index)
                this.dataArray.NextByte();
            Assert.AreEqual<int>(expected, this.dataArray.Pointer);
        }

        [TestMethod]
        public void Call30001Times_Equals0()
        {
            for (int index = 0; index < 30001; ++index)
                this.dataArray.NextByte();
            Assert.AreEqual<int>(0, this.dataArray.Pointer);
        }
    }
}