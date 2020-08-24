namespace maxmin
{
    public class ULong : IMaxMin
    {
        public long maxULong = long.MaxValue;
        public long minULong = long.MinValue;

        public void rPrint()
        {
            try
            {
                System.Console.WriteLine($"ULong range value: {minULong} to {maxULong}\n");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }

        }
    }
}