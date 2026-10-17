using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Timers;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeTop150.Arrays
{

    /// <summary>
    /// I will implement the merge sort in V1 with a recursive pattern so i it start with the left part,
    /// divide it then sort it then merge it to the first method call then goes to the next branch.
    /// this solution usses more space will sorting and it is normal 
    /// I hope u like this solution and if any found intersiting will be added later
    /// </summary>

    public static class MergeSort
    {
        // l start of part 
        // r end of part
        public static void MergeSortV1(int[] arr, int l, int r)
        {
            // we couldn't reverse the condtion as the sorting also happens here so early return is not a good choice
            if (r > l) // to stop dividng and go to sort as if they are equal this is the base case  
            {
                int m = (l + r) / 2;  // this is the index we will divide at

                MergeSortV1(arr, l, m);  //here we take the left part from start (l) to middle (m)

                MergeSortV1(arr, m + 1, r); //here we take the right part from after end (m+1) to real end (r)
                                            //NOTE: this WILL NOT BE DONE until the first method calls ends.

                Sort(arr, l, m, r); // this sort will happen to the right part first due to the functions order haha

            }

        }
        public static void Sort(int[] arr, int l, int m, int r)
        // l for start of first part, m for start of second and end of first parts, and r for end of second part 
        {
            int[] temp = new int[arr.Length];
            int i = l; //iterator for first part 
            int j = m + 1; //for second
            int k = 0; // for the new part
            while (i <= m && j <= r) // here we will loop till any part of first or second ends..
            {
                if (arr[i] >= arr[j])
                {
                    temp[k++] = arr[j++];
                }
                else
                {
                    temp[k++] = arr[i++];

                }
            } // here when we get out we need to know wich one has breaked the bounds to continue filling from the other one
            while (i <= m)
            {
                temp[k++] = arr[i++];
            }
            while (j <= r)
            {
                temp[k++] = arr[j++];
            }
            // i used a new property in c sharp that let u make two itterartors
            for (int s = l, t = 0; s <= r; s++, t++)// now we copy the edited part to our orginal array sent to method by refrence 

            {
                arr[s] = temp[t];
            }
        }


        public static void MergeQ(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1; // iterator for the last valid element in first
            int j = n - 1; // iterator for the last valid element in second
            int k = m + n - 1; // iterator for the last element in first

            // Compare the last valid elements of both arrays and put the bigger one at the end of nums1.
            // Keep moving backward until one of the arrays has no valid elements left.
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    // The current element in nums1 is bigger, so move it to the last available place.
                    // We can safely move it because we're working backward and the next elements will be smaller
                   
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    // Otherwise, take the element from nums2.
                    // It belongs here because the remaining elements are smaller and will go before it.
                    nums1[k--] = nums2[j--];
                }
            }

            // If nums2 still has elements, put them in the remaining places in nums1.
            // If nums2 is empty, the remaining elements in nums1 are already in the right places.
            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }


        /// Conclusion:
        /// Unlike many animations, Merge Sort does not create a separate array for every division.
        /// Instead, it uses index boundaries to divide the original array logically.
        /// A temporary array is used during merging, but it may contain unused space
        /// because only the section being merged is filled, while the rest remains unused.
    }
}