using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var m = 3;
            var nums2 = new int[] { 2, 5, 6 };
            var n = 3;

            Merge(nums1,m,nums2,n);
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int m2idnex = n - 1;
            int m1index = m - 1;
            for (int i = m + n - 1; i >= 0; i--)
            {
                if (m2idnex == -1)
                {
                    break;
                }
                else if (m1index == -1 || nums2[m2idnex] >= nums1[m1index])
                {
                    nums1[i] = nums2[m2idnex--];
                }
                else
                {
                    nums1[i] = nums1[m1index--];
                }
            }
        }
    }
}
