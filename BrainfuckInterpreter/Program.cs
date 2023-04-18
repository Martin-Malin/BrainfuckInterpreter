using System.Text;

internal class Program
{
    private static byte[] data = new byte[30000];
    private static int pointer = 0;

    private static void Main(string[] args)
    {
        string[] commands = args[0].Split("");

        List<int> loopIndexes = new List<int>();
        for (int i = 0; i < commands.Length; i++)
        {
            switch (commands[i])
            {
                case "+":
                    IncreaseData();
                    break;
                case "-":
                    DecreaseData();
                    break;
                case "<":
                    PreviousByte();
                    break;
                case ">":
                    NextByte();
                    break;
                case ".":
                    byte byteOutput = GetValue();
                    string consoleOutput = Encoding.ASCII.GetString(new byte[] { byteOutput });
                    Console.Write(consoleOutput);
                    break;
                case ",":
                    int key = Console.Read();
                    byte[] byteInput = Encoding.ASCII.GetBytes(Convert.ToChar(key).ToString());
                    SetValue(byteInput[0]);
                    break;
                case "[":
                    if (data[pointer] == 0)
                    {
                        loopIndexes.Add(pointer);
                        do
                        { i++; } while (commands[i] != "]");
                    }
                    break;
                case "]":
                    if (data[pointer] != 0)
                    {
                        i = loopIndexes.Last();
                    }
                    break;
            }
        }
    }

    public static void NextByte()
    {
        if (pointer == data.Length)
            pointer = 0;
        else
            ++pointer;
    }

    public static void PreviousByte()
    {
        if (pointer == 0)
            pointer = 30000;
        else
            --pointer;
    }

    public static void IncreaseData()
    {
        ++data[pointer];
    }

    public static void DecreaseData()
    {
        --data[pointer];
    }

    public static byte GetValue()
    {
        return data[pointer];
    }

    public static void SetValue(byte value)
    {
        data[pointer] = value;
    }
}