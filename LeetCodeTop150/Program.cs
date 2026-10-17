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


            
                int[] nums1 = { 1, 2, 3, 0, 0, 0 };
                int m = 3;

                int[] nums2 = { 2, 5, 6 };
                int n = 3;

                 MergeSort.MergeQ(nums1, m, nums2, n);

                Console.WriteLine(string.Join(", ", nums1));
            


        }
    }
}
