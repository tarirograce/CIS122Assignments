namespace Merged_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 }; // nums1 has extra space for nums2
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;

            MergingArray merger = new MergingArray();
            merger.Merge(nums1, m, nums2, n);

            Console.WriteLine($"Merged array: [{string.Join(", ", nums1)}]");
        }
    }
}
