namespace maxmin
{
    public class Long : IMaxMin
    {
        public long maxLong = long.MaxValue;
        public long minLong = long.MinValue;

        public void rPrint()
        {
            try
            {
                System.Console.WriteLine($"Long range value: {minLong} to {maxLong}\n");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }

        }
    }
}