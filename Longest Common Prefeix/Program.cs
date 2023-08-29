
// this wont be like copy paste answer . you have to modify it to worn in leetcode editor.

class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the no of strings to enter : ");
        int num = int.Parse(Console.ReadLine());
        var ss = new List<string>();
        for(int i = 0; i< num; i++)
        {
            var str = Console.ReadLine();
            ss.Add(str);
        }
        string shortest = ss.OrderBy(s => s.Length).First();
        int x = 0;
        for (int i = 0; i < shortest.Length; i++)
        {
            if (ss.Select(s => s[i]).Distinct().Count() > 1)
            {
                Console.WriteLine(shortest[..i]);
                x = 1;
                break;
            }
        }
        if(x==0)
        {
            Console.WriteLine(shortest);
        }
    }
}