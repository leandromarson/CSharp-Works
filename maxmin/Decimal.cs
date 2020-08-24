namespace maxmin
{
    public class Decimal : IMaxMin
    {
        public decimal maxDecimal = decimal.MaxValue;
        public decimal minDecimal = decimal.MinValue;

        public void rPrint()
        {
            try
            {
                System.Console.WriteLine($"Decimal range value: {minDecimal} to {maxDecimal}\n ");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }

        }
    }
}