namespace Batch_1
{
    public class Program
    {
        static void Main()
        {
            CustomStopWatch sw = new();
            sw.Start();
    //----------------------------------------------------------------------------------------------------

            int[] arr = {1, 1, 3, 4, 6, 5};
            Console.WriteLine(HasDuplicateChanllenge.HasDuplicate(arr));

    //----------------------------------------------------------------------------------------------------
            sw.Stop();

            Console.WriteLine(
                $"StopWatch elapsed: {(double)sw.ElapsedMilliseconds / 1000} seconds, StartAt: {sw?.StartAt!.Value}, EndAt:{sw?.EndAt!.Value}"
            );

        }
    }
}