using System.Numerics;
internal class Program
{
    private static void Main(string[] args)
    {
        BigInteger b = BigInteger.Pow(2, 1000);
        BigInteger sum = 0;
        while(b > 0){
            BigInteger rem;
            b = BigInteger.DivRem(b, 10, out rem);
            sum+=rem;
        }
        Console.WriteLine(sum);
    }
}