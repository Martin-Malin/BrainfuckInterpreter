using BrainfuckInterpreter;

namespace BrainfuckInterpreterTest.DataArrayTest
{
    [TestClass]
    public class DecreaseDataTest
    {
        DataArray dataArray = new DataArray();

        [TestMethod]
        public void CallNextNTimes_EqualsN()
        {
            int expected = Random.Shared.Next(byte.MaxValue);
            for (int index = 0; index < expected; index++)
                dataArray.IncreaseData();

            dataArray.DecreaseData();
            Assert.AreEqual(expected - 1, dataArray.GetData());
        }


        [TestMethod]
        public void FirstCall_Equals255()
        {
            dataArray.DecreaseData();

            Assert.AreEqual(255, dataArray.GetData());
        }
    }
}