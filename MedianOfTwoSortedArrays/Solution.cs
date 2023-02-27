using System;
using System.Collections.Generic;
using System.Text;

namespace MedianOfTwoSortedArrays
{
    public class Solution
    {
        //Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
        //The overall run time complexity should be O(log (m+n)).

        //Constrains
        //nums1.Length == m
        //nums2.Length == n
        //0 <= m <= 1000
        //0 <= n <= 1000
        //1 <= m + n <= 2000
        //-10^6 <= nums1[i], nums2[i] <= 10^6


        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0)
                return GetMedian(nums2);

            else if (nums2.Length == 0)
                return GetMedian(nums1);

            int[] mergedArray = Merge(nums1, nums2);

            return GetMedian(mergedArray);
        }
        private int[] Merge(int[] nums1, int[] nums2)
        {
            ushort nums1Length = (ushort)nums1.Length;
            ushort nums2Length = (ushort)nums2.Length;

            int[] mergedArray = new int[nums1Length + nums2Length];
            ushort mergedArrayLength = (ushort)mergedArray.Length;

            //O(log(n + m)

            //Index for nums1
            int i = 0;
            //Index for nums2
            int j = 0;
            //Index for merged Array
            int k = 0;

            int medianIndex = mergedArrayLength / 2;

            //Array is only fill until we reach the median index we dont care abot the rest of the array
            while(k <= medianIndex)
            {
                if (i >= nums1Length)
                {
                    mergedArray[k++] = nums2[j++];
                }
                else if (j >= nums2Length)
                {
                    mergedArray[k++] = nums1[i++];
                }
                else
                {
                    mergedArray[k++] = nums1[i] < nums2[j] ? nums1[i++] : nums2[j++];
                }
               
            }

            return mergedArray;
        }
        public double FindMedianSortedArraysFirstApproach(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0)
                return GetMedian(nums2);

            else if (nums2.Length == 0)
                return GetMedian(nums1);

            int[] mergedArray = Merge(nums1, nums2);

            return GetMedian(mergedArray);
        }

        private int[] MergeFirstApproach(int[] nums1, int [] nums2)
        {
            ushort nums1Length = (ushort)nums1.Length;
            ushort nums2Length = (ushort)nums2.Length;

            int[] mergedArray = new int[nums1Length + nums2Length];
            ushort mergedArrayLength = (ushort)mergedArray.Length;

            //O(n + m) First Approach

            //Index for nums1
            int i = 0;
            //Index for nums2
            int j = 0;
            
            for(int k = 0; k < mergedArrayLength; k++)
            {
                if(i >= nums1Length)
                {
                    mergedArray[k] = nums2[j++];
                }
                else if(j >= nums2Length)
                {
                    mergedArray[k] = nums1[i++];
                }
                else
                {
                    mergedArray[k] = nums1[i] < nums2[j] ? nums1[i++] : nums2[j++];
                }
            }

            return mergedArray;
        }

        private double GetMedian(int [] nums)
        {
            ushort length = (ushort)nums.Length;
            double result = 0;
            //Pair
            if(length % 2 == 0)
            {
                int medianIndex = length / 2;
                int val1 = nums[medianIndex];
                int val2 = nums[medianIndex - 1];
                result = (val1 + val2) / (double)2;
                
            }
            else
            {
                result = nums[(length / 2)];
            }

            return result;
        }
    }
}
