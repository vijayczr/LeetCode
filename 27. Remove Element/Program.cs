public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int j = 0;
        for (int i = 0; i < nums.Count(); i++)
        {
            if (nums[i] != val)
            {
                j++;
            }
            else
            {
                for (int k = i + 1; k < nums.Count(); k++)
                {
                    if (nums[k] != val)
                    {
                        int temp = nums[k];
                        nums[k] = val;
                        nums[i] = temp;
                        j++;
                        break;
                    }
                }
            }
        }
        return j;
    }
}

class program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine("Enter the size of the array");
        int y = int.Parse(Console.ReadLine());
        var nums  = new int[y];
        Console.WriteLine("enter the values of the list");
        for(int i = 0; i<y; i++)
        {
            int m = int.Parse(Console.ReadLine());
            nums[i] = m;
        }
        Console.WriteLine("Enter the Value to be removed");
        int val = int.Parse(Console.ReadLine());
        int f = solution.RemoveElement(nums, val);
        for(int j = 0; j<f; j++)
        {
            Console.WriteLine(nums[j]);
        }
    }
}