using LeetCodeTop150.Arrays;

namespace LeetCodeTop150
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 3, 5, 1, 9, 2, 7, 4, 6 };

            MergeSort.MergeSortV1(arr, 0, arr.Length - 1);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
