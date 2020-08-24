namespace maxmin
{
    public class Int : IMaxMin
    {
        public int maxInt = int.MaxValue;
        public int minInt = int.MinValue;

        public void rPrint()
        {
            try
            {
                System.Console.WriteLine($"Int range value: {minInt} to {maxInt}\n");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }

        }
    }
}