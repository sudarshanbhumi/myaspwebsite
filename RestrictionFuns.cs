using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemo
{
    class RestrictionFuns
    {
        public static void TestRes()
        {
            List<int> nums = new List<int>()
            {
                1,2,3,4,5,6,7,8,9
            };
            IEnumerable<int> evennumbers = nums.Where(x => x % 2 == 0);
            var evennumber = nums.Select((index, num) => new { Index = index, num = num }).
                                    Where(x=>x.num%2==0).Select(x=>x.Index);
            foreach (var i in evennumber)
            {
               // Console.WriteLine($"Index is {i.Index} and number is { i.num}");
                Console.WriteLine($"Index is {i}");
            }
        }
    }
}
