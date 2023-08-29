
class Solutions
{
    public static void Main(string[] args)
    {
        Dictionary<char, int> dict = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
    var s = Console.ReadLine();

        s.ToCharArray();
        int result = 0;
        int intVal;
        for (int i = 0; i < s.Length; i++)
        {
            intVal = dict[s[i]];
            if (i != s.Length - 1)
            {
                if (dict[s[i + 1]] > intVal)
                {
                    intVal = dict[s[i + 1]] - intVal;
                    i = i + 1;
                }
            }
            result = result + intVal;
        }
        Console.WriteLine(result);
    }
}