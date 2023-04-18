using BrainfuckInterpreter;

namespace BrainfuckInterpreterTest.CommandTest
{
    [TestClass]
    public class PreviousByte
    {
        private DataArray dataArray = new DataArray();

        [TestMethod]
        public void FirstCall_Equals30000()
        {
            this.dataArray.PreviousByte();
            Assert.AreEqual<int>(30000, this.dataArray.Pointer);
        }

        [TestMethod]
        public void CallNextNTimes_EqualsN()
        {
            int num = Random.Shared.Next(30000);
            for (int index = 0; index < num; ++index)
                this.dataArray.NextByte();
            this.dataArray.PreviousByte();
            Assert.AreEqual<int>(num - 1, this.dataArray.Pointer);
        }
    }
}