using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    public class Bank
    {
        public string name { get; set; }
        public int cashOnHand { get; set; }
        public int alarmScore { get; set; }
        public int vaultScore { get; set; }
        public int securityGuardScore { get; set; }
        public bool isSecure
        {
            get
            {
                if (alarmScore <=0 && vaultScore <=0 && securityGuardScore <=0 )
                {
                    return false;
                }
                else
                {
                    return true;  
                }
            }
        }
        public static void runReconReport(int alarmScore, int vaultScore, int securityGuardScore) {
            var securityScore = new List<int> {alarmScore, vaultScore, securityGuardScore};

            if (securityScore.Max() == alarmScore) 
            {
            Console.WriteLine($"Most secure: Alarm");
            }
            else if (securityScore.Max() == vaultScore) 
            {
            Console.WriteLine($"Most secure: Vault");
            }
            else
            {
            Console.WriteLine($"Most secure: Security Guard");
            }
            if (securityScore.Min() == alarmScore) 
            {
            Console.WriteLine($"Least secure: Alarm");
            }
            else if (securityScore.Min() == vaultScore) 
            {
            Console.WriteLine($"Least secure: Vault");
            }
            else
            {
            Console.WriteLine($"Least secure: Security Guard");
            }
    }
}
}