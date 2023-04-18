using BrainfuckInterpreter;

namespace BrainfuckInterpreterTest.CommandTest
{
    [TestClass]
    public class DataCommandTest
    {
        private DataArray _dataArray = new DataArray();
        private Dictionary<string, Action> DataCommands;

        public DataCommandTest()
        {
            this.DataCommands = new Dictionary<string, Action>()
            {
                {"+", this._dataArray.IncreaseData },
                {"-", this._dataArray.DecreaseData },
                {">", this._dataArray.NextByte },
                {"<", this._dataArray.PreviousByte },
                {".", null },
                {",", null },
                {"[", null },
                {"]", null }
            };
        }

        [TestMethod]
        public void GiveCommand_ReturnAction()
        {
            foreach (KeyValuePair<string, Action> dataCommand1 in this.DataCommands)
            {
                Action dataCommand2 = new Command(this._dataArray, dataCommand1.Key).DataCommand;
                Assert.AreEqual<Action>(dataCommand1.Value, dataCommand2, "Commande '" + dataCommand1.Key + "'.");
            }
        }
    }
}

