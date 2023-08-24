public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> data = new Dictionary<int, int>();
        for (int i = 0; i < nums.Count(); i++)
        {
            if (data.ContainsKey(target - nums[i]))
            {
                return new int[] { data[target - nums[i]], i };
            }
            if (!data.ContainsKey(nums[i]))
            {
                data.Add(nums[i], i);
            }
        }
        return new int[] { 0, 0 };
    }
}