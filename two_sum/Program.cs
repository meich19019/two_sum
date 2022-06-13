using System;

namespace two_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            foreach (int i in solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9))
            {
                Console.WriteLine(i);
            }
        }
    }
}

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int numIndex = 0; numIndex <= nums.Length; numIndex++)
        {
            int targetIndex = Array.LastIndexOf(nums, target - nums[numIndex]);
            if (targetIndex > -1 && targetIndex != numIndex)
            {
                return new int[] { numIndex, targetIndex };
            }
        }
        return new int[] { };
    }
}