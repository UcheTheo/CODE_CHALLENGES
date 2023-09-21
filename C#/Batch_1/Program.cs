namespace Batch_1
{
    public class Program
    {
        static void Main()
        {
            CustomStopWatch sw = new();
            int[] arr = {3, 1, 3, 2};
            sw.Start();
            int[] result = ProdArrayExceptSelf.ProdArrV2(arr);
            for (int i = 0; i < result.Length; i++)
                Console.Write("{0} ", result[i]);
            Console.WriteLine();
            sw.Stop();

            Console.WriteLine(
                $"StopWatch elapsed: {(double)sw.ElapsedMilliseconds / 1000} seconds, StartAt: {sw?.StartAt!.Value}, EndAt:{sw?.EndAt!.Value}"
            );

        }
    }
}