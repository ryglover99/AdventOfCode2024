using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Day_1
{
    public class Day1
    {
        public (List<int>, List<int>) ParseInputFileIntoTwoLists(string location)
        {
            if (!File.Exists(location))
            {
                return (new List<int>(), new List<int>());
            }

            string input = File.ReadAllText(location);

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            var split = input.Split("\r\n");
            
            foreach (string line in split)
            {
                var nums = line.Split("   ");
                list1.Add(Int32.Parse(nums[0]));
                list2.Add(Int32.Parse(nums[1]));
            }

            return (list1, list2);
        }


        public int FindLowestNumberInList(List<int> list)
        {

            list.Sort((a, b) => b.CompareTo(a));

            return list.Last();
        }

    }
}
