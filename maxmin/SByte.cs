namespace maxmin
{
    public class SByte : IMaxMin
    {
        public sbyte maxSByte = sbyte.MaxValue;
        public sbyte minSByte = sbyte.MinValue;

        public void rPrint()
        {            
            try
            {
                System.Console.WriteLine($"SByte range value: {minSByte} to {maxSByte}\n");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }

        }

    }
}