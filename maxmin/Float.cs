namespace maxmin
{
    public class Float : IMaxMin
    {
        public float maxFloat = float.MaxValue;
        public float minFloat = float.MinValue;

        public void rPrint()
        {
            try
            {
                System.Console.WriteLine($"Float range value: {minFloat} to {maxFloat}\n ");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }

        }
    }
}