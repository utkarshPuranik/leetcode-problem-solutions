using System;
using System.Collections;

public class TwoSumSolution {
    public int[] TwoSum(int[] nums, int target) {
        Hashtable hst = new Hashtable();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hst.ContainsKey(nums[i]))
                hst[nums[i]] = i;
            else
                hst.Add(nums[i], i);
        }
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (hst.ContainsKey(complement) && Convert.ToInt32(hst[complement]) != i)
                return new int[] { i, Convert.ToInt32(hst[complement]) };
        }
        return null;
    }
}