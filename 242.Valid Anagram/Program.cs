public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        var arr = new HashSet<char>(s);

        foreach (var data in arr)
        {
            if (s.Count(e => e == data) != t.Count(w => w == data))
            {
                return false;
            }
        }
        return true;
    }
}

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter strings!");
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        var g = new Solution();
        bool n = g.IsAnagram(s, t);
        Console.WriteLine(n);
    }
}