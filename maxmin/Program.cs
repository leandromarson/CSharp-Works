using System;

namespace maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            Char rangeChar = new Char();

            SByte rangeSByte = new SByte();
            Byte rangeByte = new Byte();

            Short rangeShort = new Short();
            UShort rangeUShort = new UShort();

            Int rangeInt = new Int();
            UInt rangeUInt = new UInt();

            Long rangeLong = new Long();
            ULong rangeULong = new ULong();

            Float rangeFloat = new Float();
            Double rangeDouble = new Double();
            Decimal rangeDecimal = new Decimal();

            rangeChar.rPrint();
            rangeSByte.rPrint();
            rangeByte.rPrint();
            rangeShort.rPrint();
            rangeUShort.rPrint();
            rangeInt.rPrint();
            rangeUInt.rPrint();
            rangeLong.rPrint();
            rangeULong.rPrint();
            rangeFloat.rPrint();
            rangeDouble.rPrint();
            rangeDecimal.rPrint();

            Console.ReadKey();

        }
    }
}
