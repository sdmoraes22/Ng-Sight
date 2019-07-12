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
        internal static string MakeUniqueCustomersName(List<string> names)
        {
            var maxNames = bizPrefix.Count * bizSuffix.Count;
            
            var prefix = GetRandom(bizPrefix);
            var suffix = GetRandom(bizSuffix);
            var bizName = prefix + suffix;

            if(names.Count >= maxNames) 
            {
                throw new System.InvalidOperationException("Maximum number of unique names exceeded");
            }

            if(names.Contains(bizName)) 
            {
                MakeUniqueCustomersName(names);
            }

            return bizName;
        }

        internal static string MakeCustomerEmail(string customerName)
        {
            return $"contact@{customerName.ToLower()}.com";
        }

        internal static string GetRandomState()
        {
            return GetRandom(usStates);
        }

        internal static decimal GetRandomOrderTotal()
        {
            return _rand.Next(100, 5000);
        }

        private static readonly List<string> usStates = new List<string>() {
            "AK", "AL", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA",
            "AV", "ASK", "SAK", "RAK", "WAK", "ABK", "AAK", "ASK", "ADK", "GWA", 
            "AKA", "AKS", "AKD", "AKQ", "AWW", "AKE", "AKR", "AKT", "AKY", "GAA", 
            "AKAA", "AKSS", "AKDD", "AKFF", "AKGG", "AKHH", "ASSK", "AAAK", "ASDK", "GSDA", 
            "AKDDA", "AKDD", "AASWK", "AKASDW", "ASWAK", "ADAAK", "ASDAK", "ADSAK", "AASDK", "GASDA" 
        }; 
        private static readonly List<string> bizPrefix = new List<string>() {
            "ABC",
            "XYZ",
            "MainSt",
            "Enterprise",
            "Ready",
            "Quick",
            "Budget",
            "Peak",
            "Magic",
            "Family",
            "Comfort"
        };

        private static readonly List<string> bizSuffix = new List<string>() {
            "Corporation",
            "Co",
            "Logistics",
            "Transit",
            "Bakery",
            "Goods",
            "Foods",
            "Cleaners",
            "Hotels",
            "Planners",
            "Automotive",
            "Books"
        };
    }
}