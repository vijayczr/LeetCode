public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int x = digits.Count() - 1;
        for (int i = x; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                digits[i]++;
                return digits;
            }
            else
            {
                digits[i] = 0;
            }
        }
        if (digits[0] == 0)
        {
            digits[0] = 1;
            var term = digits.ToList();
            term.Add(0);
            int[] tersm = term.ToArray();
            return tersm;
        }
        return digits;
    }
}

class program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine("enter the number of indexes to enter");
        int y = int.Parse(Console.ReadLine());
        int[] digits = new int[y];
        for(int i =0;i<y; i++)
        {
            digits[i] = int.Parse(Console.ReadLine());
        }
        int[] res = solution.PlusOne(digits);
        for(int j =0; j < res.Length; j++)
        {
            Console.WriteLine(res[j]);
        }
    }
}