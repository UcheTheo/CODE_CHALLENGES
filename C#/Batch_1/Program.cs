namespace Batch_1
{
    public class Program
    {
        static void Main()
        {
            CustomStopWatch sw = new();

            sw.Start();
            Console.WriteLine(LargestPalindromeChallenge.IsPalindromeStr("MADA"));
            sw.Stop();

            Console.WriteLine(
                $"StopWatch elapsed: {(double)sw.ElapsedMilliseconds / 1000} seconds, StartAt: {sw?.StartAt!.Value}, EndAt:{sw?.EndAt!.Value}"
            );

        }
    }
}