using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualSalaries
{
    class MergeSort
    {
        public static int[] Sort(int[] array)
        {
            return MergeSortAux(array);
        }

        private static int[] MergeSortAux(int[] arr)
        {
            int[] left;
            int[] right;
            int[] result = new int[arr.Length];

            // used to avoid infinite recursion/stackoverflow errors
            if (arr.Length <= 1)
                return arr;

            // find the middle point
            int mid = arr.Length / 2;

            // represents the left array
            left = new int[mid];

            // check if the arry has an even or odd amount of elements
            // if even left and right array with have same amount of elements
            if (arr.Length % 2 == 0)
                right = new int[mid];
            // if odd right array will have 1 more element
            else
                right = new int[mid + 1];

            // populate left array
            for (int i = 0; i < mid; i++)
                left[i] = arr[i];

            // populate right array, starting from the mid point
            int x = 0;
            for (int i = mid; i < arr.Length; i++)
            {
                right[x] = arr[i];
                x++;
            }

            //Recursively sort the left array
            left = MergeSortAux(left);

            //Recursively sort the right array
            right = MergeSortAux(right);

            //Merge our two sorted arrays
            result = Merge(left, right);

            return result;
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            int indexLeft = 0, indexRight = 0, indexResult = 0;

            // while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                // if both arrays still have elements
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    // if left array item is less than right array item add item to the results array
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else add the right item to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                // if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                // if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }
}
