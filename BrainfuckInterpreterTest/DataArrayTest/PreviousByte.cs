using BrainfuckInterpreter;

namespace BrainfuckInterpreterTest.DataArrayTest
{
    [TestClass]
    public class PreviousByte
    {
        private DataArray dataArray = new DataArray();

        [TestMethod]
        public void FirstCall_Equals30000()
        {
            dataArray.PreviousByte();
            Assert.AreEqual(30000, dataArray.Pointer);
        }

        [TestMethod]
        public void CallNextNTimes_EqualsN()
        {
            int num = Random.Shared.Next(30000);
            for (int index = 0; index < num; index++)
                dataArray.NextByte();

            dataArray.PreviousByte();
            Assert.AreEqual(num - 1, dataArray.Pointer);
        }
    }
}