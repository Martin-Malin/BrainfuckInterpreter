using BrainfuckInterpreter;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] commands = args[0].Split("");

        DataArray dataArray = new DataArray();
        List<Command> commandes = new List<Command>();

        for (int i = 0; i < commands.Length; i++)
        {
            commandes.Add(new Command(dataArray, commands[i]));
        }
    }
}