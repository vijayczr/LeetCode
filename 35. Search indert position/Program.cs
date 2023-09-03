public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int m = nums.Count();
        for (int i = 0; i < m; i++)
        {
            if (target <= nums[i])
            {
                return i;
            }
        }
        return m;
    }
}

public class program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine("Enter the Size of ther array");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter values of the array");
        var nums = new int[y];
        for(int i = 0; i < y; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the value to be inserted");
        int target = int.Parse(Console.ReadLine());
        int t = solution.SearchInsert(nums, target);
        Console.WriteLine($"The value will be inserted at index {t}");
    }
}