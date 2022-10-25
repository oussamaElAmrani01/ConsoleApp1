using System;

public class Program
{
    public static bool EstPremier(int k)
    {
        if (k > 2)
        {
            for (int j = 2; j < k; j++)
            { 
                if (k % j == 0) 
                    return false;
            }
        }
        return true;
    }
    public static void Main(string[] args)
    {
        int num = 0;
        bool isOk  = false;
        do
        {
            Console.Write("N = ");
            string rr = Console.ReadLine();
            isOk = int.TryParse(rr, out num);
        } while (!isOk);
        Console.WriteLine(EstPremier(num));
    }
}