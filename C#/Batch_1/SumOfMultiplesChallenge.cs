namespace Batch_1;
public class SumOfMultiplesChallenge
{
    public static long SumOfFirstNNaturalNumbers(long n)
    {
        if (n <= 0) return 0;
        return n * (n + 1) / 2;
    }

    public static long SumOfMultiplesOfABeforeN(long n, long a)
    {
        n /= a;
        //return n * (n + 1) / 2 * a;
        return SumOfFirstNNaturalNumbers(n) * a;
    }

    public static long GCDV1(long a, long b)
    {
        return b == 0 ? a : GCDV1(b, a % b);
    }

    public static long GCDV2(long a, long b)
    {
        while (b != 0)
        {
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static long LCM(long a, long b)
    {
        return (a * b) / GCDV1(a, b);
    }

    public static long SumOfMultiples(long n, long a, long b)
    {
        n--;
        return (SumOfMultiplesOfABeforeN(n, a) + SumOfMultiplesOfABeforeN(n, b) - SumOfMultiplesOfABeforeN(n, LCM(a, b)));
    }

    ///<summary>
    /// MultiplesOf3And5 calculates the sum of numbers that are multiples
    /// of 3 and 5 that are below a given number (n). 
    /// </summary>
    /// <remarks> Big O: Time complexity - O(1) </remarks>
    /// <param name="n">The given number </param>
    /// <returns>Sum of the multiples of 3 and 5 below n </returns>
    public static long MultiplesOf3And5(long n)
    {
        long highVal3 = (n - 1) / 3;
        long sum3 = highVal3 * ((highVal3 + 1) / 2) * 3;

        long highVal5 = (n - 1) / 5;
        long sum5 = highVal5 * ((highVal5 + 1) / 2) * 5;

        long highVal15 = (n - 1) / 15;
        long sum15 = highVal15 * ((highVal15 + 1) / 2) * 15;

        return sum3 + sum5 - sum15;
    }

}
