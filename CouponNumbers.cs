using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumbers
    {
        public static void Main()
        {
            int[] couponNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Array of distinct coupon numbers

            int totalRandomNumbersNeeded = GetDistinctCouponCount(couponNumbers);

            Console.WriteLine($"Total random numbers needed to obtain all distinct coupons: {totalRandomNumbersNeeded}");
        }

        public static int GetDistinctCouponCount(int[] couponNumbers)
        {
            Random random = new Random();
            HashSet<int> distinctCoupons = new HashSet<int>();

            int count = 0;

            while (distinctCoupons.Count < couponNumbers.Length)
            {
                int randomNumber = random.Next(1, couponNumbers.Length + 1);
                count++;

                if (!distinctCoupons.Contains(randomNumber))
                {
                    distinctCoupons.Add(randomNumber);
                }
            }

            return count;
        }
    }
}
