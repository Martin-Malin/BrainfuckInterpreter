namespace BrainfuckInterpreter
{
    public class DataArray
    {
        private byte[] data = new byte[30000];
        public int Pointer = 0;

        public DataArray()
        {
            //Initialisation du tableau de données à 0
            for (int index = 0; index < this.data.Length; ++index)
                this.data[index] = 0;
        }

        public void NextByte()
        {
            if (this.Pointer == this.data.Length)
                this.Pointer = 0;
            else
                this.Pointer++;
        }

        public void PreviousByte()
        {
            if (this.Pointer == 0)
                this.Pointer = 30000;
            else
                this.Pointer--;
        }

        public void IncreaseData()
        {
            this.data[this.Pointer]++;
        }

        public void DecreaseData()
        {
            this.data[this.Pointer]--;
        }

        public byte GetData()
        {
            return this.data[this.Pointer];
        }

        public void SetData(byte value)
        {
            this.data[this.Pointer] = value;
        }
    }
}
