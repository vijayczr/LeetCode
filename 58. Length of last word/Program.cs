public class Solution
{
    public int LengthOfLastWord(string s)
    {
        string m = s.Trim();
        int j = 0;
        for (int i = m.Length - 1; i >= 0; i--)
        {
            if (m[i] == ' ')
            {
                break;
            }
            j++;
        }
        return j;
    }
}
class program
{
    public static void Main(string[] args)
    {
        Solution ss = new Solution();
        Console.WriteLine("Enter the string");
        string s = Console.ReadLine();
        int m = ss.LengthOfLastWord(s);
        Console.WriteLine($"The length of last wrod is {m}");

    }
}