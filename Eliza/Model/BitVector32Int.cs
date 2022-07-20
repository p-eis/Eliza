using MessagePack;
using System;

namespace Eliza.Model
{
    [MessagePackObject]
	public class BitVector32Int
	{
		[Key(0)]
		public uint data;
        [Key(1)]
		public int this[Section section]
        {
			get
            {
				if (section.BitCount == 0) { return 0; }
				int val = (int)(data & (section.Mask << section.Offset)) >> section.Offset;
				if (section.IsSigned)
				{
					int numShifts = section.BitCount - 1;
					bool highBit = Convert.ToBoolean(val >> numShifts);
					val &= (int)(section.Mask >> 1);
					val = highBit || section.BitCount >= 32 ? -val : val;
                }
				return val;
            }
			set
            {
				if (section.BitCount == 0) { return; }
				uint temp = (uint)value << section.Offset;
				uint tempMask = section.Mask << section.Offset;
				temp &= tempMask;
				data &= ~tempMask;
				data |= temp;
            }
        }
        [Key(2)]
		public bool this[int bit]
        {
			get
            {
				if (bit > 31) { throw new ArgumentOutOfRangeException($"{nameof(bit)}: {bit}"); }
				uint temp = (uint)1 << bit;
				return (temp & data) != 0;
            }
			set
            {
				if (bit > 31) { throw new ArgumentOutOfRangeException($"{nameof(bit)}: {bit}"); }
				uint temp = Convert.ToUInt32(value) << bit;
				data = ~temp;
				if (value)
                {
					data &= temp;
                }
            }
        }

		public static Section CreateSection(uint numBits, bool signed = false)
        {
			return CreateSection(numBits, 0, signed);
        }
		public static Section CreateSection(uint numBits, short offset, bool signed = false)
        {
			uint mask = 0;
			for (int i = 0; i < numBits; i++)
            {
				mask &= (uint)1 << i;
            }
			return new Section(mask, offset, signed);
        }

		public readonly struct Section
        {
			private readonly uint mask;
			private readonly short offset;
			private readonly byte bitCount;
			private readonly bool isSigned;
			public readonly uint Mask { get => mask; }
			public readonly short Offset { get => offset; }
			public readonly byte BitCount { get => bitCount; }
			public readonly bool IsSigned { get => isSigned; }

			public Section(uint _mask, short _offset, bool _signed)
            {
				mask = _mask;
				offset = _offset;
				isSigned = _signed;
				
				if (mask == 0)
                {
					bitCount = 0;
					return;
                }

				uint temp = _mask;
				byte highBit = 0;
				while (highBit < 31)
				{
					highBit++;
					temp >>= 1;
					if (temp == 0)
                    {
						break;
					}
				}
				bitCount = highBit;
            }

			public static string ToString(Section value)
            {
				return value.ToString();
            }
            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
            public override string ToString()
            {
                return base.ToString();
            }

            public static bool operator ==(Section a, Section b)
			{
				return a.mask == b.mask &&
					a.offset == b.offset &&
					a.bitCount == b.bitCount &&
					a.isSigned == b.isSigned;
			}
            public static bool operator !=(Section a, Section b) { return !(a == b); }
        }
	}
}
