public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int len = needle.Length;
        if (len > haystack.Length)
        {
            return -1;
        }
        for (int i = 0; i < haystack.Length - len + 1; i++)
        {
            string sub = haystack.Substring(i, len);
            if (String.Equals(sub, needle))
            {
                return i;
            }
        }
        return -1;
    }
}

class program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine("Enter first string");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter second string");
        string str2 = Console.ReadLine();
        int res  = s.StrStr(str1, str2);
        if(res == -1)
        {
            Console.WriteLine("No substring present");
        }
        else
        {
            Console.WriteLine($"Substring is present at index {res}");
        }
    }
}