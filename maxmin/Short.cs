namespace maxmin
{
    public class Short : IMaxMin
    {
        public short maxShort = short.MaxValue;
        public short minShort = short.MinValue;

        public void rPrint()
        {            
            try
            {
                System.Console.WriteLine($"Short range value: {minShort} to {maxShort}\n");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }

        }
    }
}