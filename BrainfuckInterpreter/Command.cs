namespace BrainfuckInterpreter
{
    public class Command
    {
        private DataArray _dataArray;
        private Dictionary<string, Action> DataCommands;

        public string OriginalCommand { get; private set; }

        public Action DataCommand => this.DataCommands[this.OriginalCommand];

        public Command(DataArray dataArray, string command)
        {
            this._dataArray = dataArray;
            this.OriginalCommand = command;
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
    }
}
