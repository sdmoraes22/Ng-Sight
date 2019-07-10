using System;
using System.Collections.Generic;

namespace Advantage.API
{
    public class Helpers
    {
        private static Random _rand = new Random();
        private static string GetRandom(IList<string> items)
        {
            var rand = new Random();
            return items[_rand.Next(items.Count)];
        }
        internal static string MakeCustomerName()
        {
            var prefix = GetRandom(bizPrefix);
            var suffix = GetRandom(bizSuffix);
            return prefix + suffix;
        }

        public static readonly List<string> bizPrefix = new List<string>() {
            "ABC",
            "asd",
            "ASW",
            "AWWW",
            "asdsadq",
            "asdfew",
            "aqxx",
            "adww",
        };

        public static readonly List<string> bizSuffix = new List<string>() {
            "ABC",
            "asd",
            "ASW",
            "AWWW",
            "asdsadq",
            "asdfew",
            "aqxx",
            "adww",
        };
    }
}