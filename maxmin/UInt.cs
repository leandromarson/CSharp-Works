namespace maxmin
{
    public class UInt : IMaxMin
    {
        public uint maxUInt = uint.MaxValue;
        public uint minUInt = uint.MinValue;

        public void rPrint()
        {
            try
            {
                System.Console.WriteLine($"UInt range value: {minUInt} to {maxUInt}\n");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }

        }
    }
}