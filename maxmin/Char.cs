namespace maxmin
{
    public class Char : IMaxMin
    {
        public char maxChar = char.MaxValue;
        public char minChar = char.MinValue;

        public void rPrint()
        {
            try
            {
                System.Console.WriteLine($"Char range value: {minChar} to {maxChar}\n");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }

        }
    }
}