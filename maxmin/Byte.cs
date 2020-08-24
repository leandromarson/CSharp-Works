namespace maxmin
{
    public class Byte : IMaxMin
    {
        public byte maxByte = byte.MaxValue;
        public byte minByte = byte.MinValue;

        public void rPrint()
        {
            try
            {
                System.Console.WriteLine($"Byte range value: {minByte} to {maxByte}\n");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }

        }
    }
}