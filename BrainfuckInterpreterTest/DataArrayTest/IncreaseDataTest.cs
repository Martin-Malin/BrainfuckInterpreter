using BrainfuckInterpreter;

namespace BrainfuckInterpreterTest.DataArrayTest
{
    [TestClass]
    public class IncreaseDataTest
    {
        DataArray dataArray = new DataArray();

        [TestMethod]
        public void CallNextNTimes_EqualsN()
        {
            int expected = Random.Shared.Next(byte.MaxValue);
            for (int index = 0; index < expected; ++index)
                dataArray.IncreaseData();

            Assert.AreEqual(expected, dataArray.GetData());
        }


        [TestMethod]
        public void Call256Times_Equals0()
        {
            for (int i = 0; i < 256; i++)
                dataArray.IncreaseData();

            Assert.AreEqual(0, dataArray.GetData());
        }
    }
}