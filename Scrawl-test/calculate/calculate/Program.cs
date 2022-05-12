using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] nums = {3,2,4};
            
            int target = 6;
            int [] newarray=FindIndex(nums,target);
            for (int i = 0; i < newarray.Length; i++)
            {
            Console.WriteLine(newarray[i]);
            }
        }
        public static int[] FindIndex(int []nums, int target)
        {
            
           
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[] { i, j };
                        }
                    }
                
            }
            return null ;
        }
    }
}
