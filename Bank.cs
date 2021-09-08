using System;

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
    }
}