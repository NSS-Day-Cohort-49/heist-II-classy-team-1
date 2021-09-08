using System;

namespace Heist
{
    public class Bank
    {
        public string Name { get; set; }
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool isSecure
        {
            get
            {
                if (AlarmScore <=0 && VaultScore <=0 && SecurityGuardScore <=0 )
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