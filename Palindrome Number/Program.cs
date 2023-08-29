using System;

class Resullt
{
    public static void Main(string[] args)
    {
        int x  = int.Parse(Console.ReadLine());
        bool m = IsPalindrome(x);

        if(m == true)
        {
            Console.WriteLine("true");
        }
        else {  Console.WriteLine("false"); }



        bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            List<int> list = new List<int>();
            while (x > 0)
            {
                list.Add(x % 10);
                x = x / 10;
            }
            for (int i = 0; i < list.Count() / 2; i++)
            {
                if (list[i] != list[list.Count() - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

    }


}