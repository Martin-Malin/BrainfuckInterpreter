using BrainfuckInterpreter;

namespace BrainfuckInterpreterTest.CommandTest
{
    [TestClass]
    public class IncreaseDataTest
    {
        DataArray dataArray = new DataArray();

        [TestMethod]
        public void FirstCall_Equals30000()
        {
            dataArray.IncreaseData();

            Assert.AreEqual(30000, dataArray.Pointer);
        }


        [TestMethod]
        public void CallNextNTimes_EqualsN()
        {
            var callNumber = Random.Shared.Next(30000);

            for (int i = 0; i < callNumber; i++)
            {
                dataArray.NextByte();
            }

            dataArray.PreviousByte();

            Assert.AreEqual(callNumber - 1, dataArray.Pointer);
        }
    }
}