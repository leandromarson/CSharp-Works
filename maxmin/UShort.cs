namespace maxmin
{
    public class UShort : IMaxMin
    {
        public ushort maxUShort = ushort.MaxValue;
        public ushort minUShort = ushort.MinValue;

        public void rPrint()
        {
            try
            {
                System.Console.WriteLine($"UShort range value: {minUShort} to {maxUShort}\n");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }

        }
    }
}