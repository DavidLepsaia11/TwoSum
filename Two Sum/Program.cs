using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    class Program
    {
        static void Main()
        {
            int[] array = { 3, 2, 4 };

            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            int [] result = Solution(array,6).ToArray();

            Console.WriteLine("Results are:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine( result[i]);
            }

            Console.ReadKey();
        }
        static List<int> Solution (int[] nums, int target)
        {
            List <int> list = new  List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        list.Add(i);
                        list.Add(j);
                    }
                }
            }
            return list;
        }
    }
}
