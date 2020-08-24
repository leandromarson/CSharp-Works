using System;

namespace maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            char maxChar = char.MaxValue;
            char minChar = char.MinValue;
                        
            sbyte maxSByte = sbyte.MaxValue;
            sbyte minSByte = sbyte.MinValue;

            byte maxByte = byte.MaxValue;
            byte minByte = byte.MinValue;

            short maxShort = short.MaxValue;
            short minShort = short.MinValue;

            ushort maxUShort = ushort.MaxValue;
            ushort minUShort = ushort.MinValue;

            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            uint maxUInt = uint.MaxValue;
            uint minUInt = uint.MinValue;

            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            
            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;

            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;

            decimal maxDecimal = decimal.MaxValue;
            decimal minDecimal = decimal.MinValue;

            System.Console.WriteLine($"Char range value: {minChar} to {maxChar}\n");

            System.Console.WriteLine($"SByte range value: {minSByte} to {maxSByte}\n");

            System.Console.WriteLine($"Byte range value: {minByte} to {maxByte}\n");

            System.Console.WriteLine($"Short range value: {minShort} to {maxShort}\n");

            System.Console.WriteLine($"UShort range value: {minUShort} to {maxUShort}\n");

            System.Console.WriteLine($"Int range value: {minInt} to {maxInt}\n");

            System.Console.WriteLine($"UInt range value: {minUInt} to {maxUInt}\n");

            System.Console.WriteLine($"Long range value: {minLong} to {maxLong}\n");

            System.Console.WriteLine($"Float range value: {minFloat} to {maxFloat}\n ");

            System.Console.WriteLine($"Double range value: {minDouble} to {maxDouble}\n ");

            System.Console.WriteLine($"Decimal range value: {minDecimal} to {maxDecimal}\n ");


            Console.ReadKey();


        }
    }
}
