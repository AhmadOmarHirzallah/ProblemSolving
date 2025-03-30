using System;


class MedianOfTwoSortedArrays
{
    /*
     * Instead of merging both arrays (which is O(m + n)),
     * we do binary search on the shorter array to partition
     * both arrays into left and right halves such that:
     *       Max of left half ≤ Min of right half : 
     *       Once this condition is satisfied, we can compute the median directly.
     *       
     *       
     *       Let’s assume we have:
     *       nums1 and nums2, both sorted.
     *       Always binary search on the shorter array to minimize time.
     *       We divide the arrays into left and right parts by "cutting" them at some index (partition).
     */

    /*
        nums1 = [1, 3]
        nums2 = [2]

        We want to partition like:
           [1] | [3]        → Left1 | Right1
           [2] | []         → Left2 | Right2
        Now:
          maxLeft = max(Left1 last, Left2 last) = max(1, 2)
          minRight = min(Right1 first, Right2 first) = min(3, ∞)
        
        If maxLeft <= minRight → VALID PARTITION
        Median = (maxLeft + minRight) / 2 if even
               = maxLeft if odd
     */



    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        // Ensure nums1 is the smaller array (binary search on smaller one)
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);

        int len1 = nums1.Length;
        int len2 = nums2.Length;

        int low = 0;
        int high = len1;

        while (low <= high)
        {
            // 🔪 Partition index for nums1 and nums2
            int cut1 = (low + high) / 2;
            int cut2 = (len1 + len2 + 1) / 2 - cut1;

            // 📌 Get elements around the partition
            int left1 = (cut1 == 0) ? int.MinValue : nums1[cut1 - 1];
            int right1 = (cut1 == len1) ? int.MaxValue : nums1[cut1];

            int left2 = (cut2 == 0) ? int.MinValue : nums2[cut2 - 1];
            int right2 = (cut2 == len2) ? int.MaxValue : nums2[cut2];

            // ✅ Found correct partition
            if (left1 <= right2 && left2 <= right1)
            {
                // Total length is even
                if ((len1 + len2) % 2 == 0)
                    return (Math.Max(left1, left2) + Math.Min(right1, right2)) / 2.0;
                else
                    return Math.Max(left1, left2); // Total length is odd
            }
            else if (left1 > right2)
            {
                // 📉 Too far right in nums1 → move left
                high = cut1 - 1;
            }
            else
            {
                // 📈 Too far left in nums1 → move right
                low = cut1 + 1;
            }
        }

        throw new ArgumentException("Input arrays are not sorted properly.");
    }
}


class Program
{
    static void Main()
    {
        int[] nums1 = { 1, 2 };
        int[] nums2 = { 3, 4 };

        MedianOfTwoSortedArrays finder = new MedianOfTwoSortedArrays();
        double median = finder.FindMedianSortedArrays(nums1, nums2);

        Console.WriteLine($"The median is: {median}");
    }
}
