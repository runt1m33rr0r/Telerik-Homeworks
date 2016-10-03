namespace _05_BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray : IEnumerable<int>
    {
        private const int Length = 64;
        private int[] bitArray;

        public BitArray(ulong value)
        {
            string bits = DecToBinary(value);

            this.bitArray = BitsToArray(bits);
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > Length - 1)
                {
                    throw new ArgumentException("Index is out of boundaries of Bitarray64!");
                }

                return this.bitArray[this.bitArray.Length - 1 - index];
            }
        }

        public static bool operator ==(BitArray firstArr, BitArray secondArr)
        {
            return firstArr.Equals(secondArr);
        }

        public static bool operator !=(BitArray firstArr, BitArray secondArr)
        {
            return !firstArr.Equals(secondArr);
        }

        public static string DecToBinary(ulong number)
        {
            string result = string.Empty;

            do
            {
                ulong digit = number % 2;
                result = digit + result;
                number /= 2;
            }
            while (number != 0);

            return result.ToString().PadLeft(64, '0');
        }

        public static int[] BitsToArray(string bits)
        {
            var bitArray = new int[64];

            for (int i = 0; i < bitArray.Length; i++)
            {
                bitArray[i] = int.Parse(bits[i].ToString());
            }

            return bitArray;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in this.bitArray)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            var otherArr = obj as BitArray;

            for (int i = 0; i < Length; i++)
            {
                if (this.bitArray[i] != otherArr.bitArray[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.bitArray.GetHashCode();
        }

        public override string ToString()
        {
            return string.Join(string.Empty, this.bitArray);
        }
    }
}
