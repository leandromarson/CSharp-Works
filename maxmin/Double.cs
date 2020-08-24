namespace maxmin
{
    public class Double : IMaxMin
    {
        public double maxDouble = double.MaxValue;
        public double minDouble = double.MinValue;

        public void rPrint()
        {
            try
            {
                System.Console.WriteLine($"Double range value: {minDouble} to {maxDouble}\n ");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }

        }
    }
}