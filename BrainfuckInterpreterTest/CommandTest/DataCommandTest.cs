using BrainfuckInterpreter;

namespace BrainfuckInterpreterTest.CommandTest
{
    [TestClass]
    public class DataCommandTest
    {
        private DataArray dataArray = new DataArray();
        private Dictionary<string, Action> dataCommands;

        public DataCommandTest()
        {
            dataCommands = new Dictionary<string, Action>()
            {
                {"+", dataArray.IncreaseData },
                {"-", dataArray.DecreaseData },
                {">", dataArray.NextByte },
                {"<", dataArray.PreviousByte },
                {".", null },
                {",", null },
                {"[", null },
                {"]", null }
            };
        }

        [TestMethod]
        public void GiveCommand_ReturnAction()
        {
            foreach (KeyValuePair<string, Action> dataCommand1 in dataCommands)
            {
                Action dataCommand2 = new Command(dataArray, dataCommand1.Key).DataCommand;
                Assert.AreEqual<Action>(dataCommand1.Value, dataCommand2, "Commande '" + dataCommand1.Key + "'.");
            }
        }
    }
}

