using System;
public class funcexer9
{
    public static bool chkprime(int num)
    {
        for (int i = 2; i < num; i++)
            if (num % i == 0)
                return false;
        return true;
    }
    public static void Main()
    {
        
        int n = Convert.ToInt32(Console.ReadLine());

        if (chkprime(n))
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}
