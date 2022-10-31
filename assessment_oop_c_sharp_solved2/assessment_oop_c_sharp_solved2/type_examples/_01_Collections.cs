using System;
using System.Collections.Generic;

namespace assessment_oop_c_sharp_solved2.type_examples
{
    public class _01_Collections
    {
        public static Dictionary<string, string> myDict = new Dictionary<string, string>()
        {
            { "a","x" },
            { "b","x" }
        };

        public static SortedDictionary<string, int> mySortedDict = new SortedDictionary<string, int>()
        {
            { "A", 2 },
            { "Z", 1 }
        };

        public static List<string> myList = new List<string>()
        {
            "NY",
            "NJ"
        };

        public static List<Pojo> myListPojo = new List<Pojo>()
        {
            new Pojo() { name = "Mark" }
        };

        public static HashSet<int> mySet = new HashSet<int>()
        {
            1,
            3
        };

        public static Queue<string> myQueue = new Queue<string>();  // Managed by first in first out

        public static Stack<string> myStack = new Stack<string>();  // Managed by last in first out

        public _01_Collections()
        {
            mySortedDict.Add("K", 5);
        }

    }


    public class Pojo
    {
        public string name { get; set; }
    }
}

