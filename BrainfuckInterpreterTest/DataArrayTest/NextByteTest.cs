using BrainfuckInterpreter;

namespace BrainfuckInterpreterTest.DataArrayTest
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
                dataArray.NextByte();
            Assert.AreEqual(expected, dataArray.Pointer);
        }

        [TestMethod]
        public void Call30001Times_Equals0()
        {
            for (int index = 0; index < 30001; ++index)
                dataArray.NextByte();
            Assert.AreEqual(0, dataArray.Pointer);
        }
    }
}