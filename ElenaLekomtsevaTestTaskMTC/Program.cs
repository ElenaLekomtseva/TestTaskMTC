using System;
using System.Linq;

namespace ElenaLekomtsevaTestTaskMTC
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {0x07,0xf3,0x4e,0x12,0x73,0x81,0x1c,0x5e,0xe4,0x7d,0xc5,0x56,0x1a,0xce,
                0xc1,0x9a,0x1a,0xeb,0xd8,0x96,0xf0,0x1c,0x52,0x47,0x44,0x35,0xcc,0x48,
                0x93,0xdf,0x3b,0x7e,0xb8,0x18,0xba,0xb2,0xb8,0x0b,0x14,0xed,0xf7,0x91,
                0x3f,0xad,0x53,0x68,0x58,0x58,0xb0,0x5f,0xc0,0x2a,0xc3,0xe7,0x0d,0x03,
                0xc9,0x5c,0xc7,0x72,0x6f,0x23,0x5c,0x4e};
            Console.WriteLine(
                String.Format("Input array ({0}): {1}", 
                array.Length.ToString(), string.Join(", ", array)));

            // get unique elements
            int[] resultArray = array.Distinct().ToArray();
            Console.WriteLine(
                String.Format("Array with unique elements ({0}): {1}",
                resultArray.Length.ToString(), string.Join(", ", resultArray)));

            // sum odd values
            Console.WriteLine("Sum odd values: " + 
                array.Where(n => n % 2 == 1).Sum().ToString());

            // get int? array where replaced value < 40
            int?[] resultNullArray = array.Select(n => n < 40 ? null : (int?)n).ToArray();
            Console.WriteLine(
                String.Format("Array where replaced value < 40 ({0}): {1}",
                resultNullArray.Length.ToString(), string.Join(", ", resultNullArray)));

            Console.ReadKey();
        }
    }
}
